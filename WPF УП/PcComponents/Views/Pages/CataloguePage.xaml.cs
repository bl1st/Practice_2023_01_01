using PcComponents.Models.Entities;
using PcComponents.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PcComponents.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для CataloguePage.xaml
    /// </summary>
    public partial class CataloguePage : Page
    {

		private List<ProductViewModel> prods = null!;
		private MainView parent;
		public CataloguePage(MainView mv)
        {
			this.parent = mv;
            InitializeComponent();

			List<Category> cats = Helper.context.Categories.AsNoTracking().ToList();
			Category allCat = new Category();
			allCat.Id = 0;
			allCat.CategoryName = "Все";
			cats.Insert(0, allCat);
			cbCategories.ItemsSource = cats;
			cbCategories.DisplayMemberPath = "CategoryName";
			cbCategories.SelectedValuePath = "Id";
			cbCategories.SelectedIndex = 0;

			cbDiscounts.Items.Add("Все диапазоны");
			cbDiscounts.Items.Add("0-3%");
			cbDiscounts.Items.Add("3-6%");
			cbDiscounts.Items.Add("7% и более");
			cbDiscounts.SelectedIndex = 0;

			this.Title = "Каталог";

			InvalidateProducts();
		}


        private void InvalidateProducts()
        {
			productList.ItemsSource = null;

			int minDiscount = 0;
			int maxDiscount = 0;
			switch (cbDiscounts?.SelectedIndex)
			{
				case 0: maxDiscount = 100; break;
				case 1: maxDiscount = 3; break;
				case 2: maxDiscount = 6; minDiscount = 3; break;
				case 3: maxDiscount = 100; minDiscount = 7; break;
				default: maxDiscount = 100; break;
			}

			List<Product> Products;
			if (cbCategories.SelectedIndex > 0)
			{
				int selectedValue = (int)cbCategories.SelectedValue;
				Products = Helper.context.Products.Where(pr => pr.CategoryId == selectedValue && pr.Discount >= minDiscount && pr.Discount <= maxDiscount).AsNoTracking().ToList();
			}
			else
			{
				Products = Helper.context.Products.AsNoTracking().ToList();
			}
			string productName = textBlockProductName.Text;
			if (productName.Trim() != "")
			{
				Products = Products.Where(p => p.Name.Contains(productName)).ToList();
			}

			Products = (bool)rbCostAsc.IsChecked! ? Products.OrderBy(p => p.Price).ToList() : Products.OrderByDescending(p => p.Price).ToList();

			prods = new List<ProductViewModel>();
			tbProductsCount.Text = $"Найдено: {Products.Count} товаров";
			int i = 0;
			
			foreach (Product p in Products)
			{		
				byte[]? pic = Helper.context.ProductPictures.Where(pp => pp.ProductId == p.Id).AsNoTracking().FirstOrDefault()?.Picture;
				if (pic == null)
					pic = Helper.NoImage;
				Category? cat = Helper.context.Categories.Find(p.CategoryId);
				ProductViewModel pvm = new ProductViewModel();
				pvm.Product = p;
				pvm.Category = cat!.CategoryName;
				pvm.ProductPicture = pic!;
				pvm.Position = i;
				
				prods.Add(pvm);
				i++;
			}

			productList.ItemsSource = prods;
		}

		private void cbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			InvalidateProducts();
		}

		private void cbDiscounts_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			InvalidateProducts();
		}

		private void rbCostAsc_Checked(object sender, RoutedEventArgs e)
		{
			InvalidateProducts();
		}

		private void textBlockProductName_TextChanged(object sender, TextChangedEventArgs e)
		{
			InvalidateProducts();
		}

		private void ButtonBuy_Click(object sender, RoutedEventArgs e)
		{
			Button b = (sender as Button)!;
			int pos = (int) b.Tag;
			Product p = prods[pos].Product;
			Order.AddProduct(p);
			parent.textBlockCart.Text = $"Корзина: ({Order.Products.Count})";
		}

		private void productList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			int productId;
			try
			{
				ListView? lv = sender as ListView;
				if (lv?.SelectedItem == null) return;
				productId = ((ProductViewModel)((sender as ListView)!).SelectedItem).Product.Id;
			}
			catch (Exception ex) { return; }

			switch(Helper.UserRole)
			{
				case "Администратор":
					this.NavigationService.Navigate(new AdminProductPage(productId));
					break;
				default:
					this.NavigationService.Navigate(new ProductInformationPage(productId));
					break;
			}
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			string cartButtonText = "Корзина";
			if (Order.Products.Count > 0)
			{
				cartButtonText += $": ({Order.Products.Count})";
			}
			parent.textBlockCart.Text = cartButtonText;
			InvalidateProducts();
		}
    }
}
