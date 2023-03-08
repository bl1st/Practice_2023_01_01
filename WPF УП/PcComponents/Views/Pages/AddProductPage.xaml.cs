using Microsoft.Win32;
using PcComponents.Models.Entities;
using PcComponents.Services;
using PcComponents.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
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
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
		Product product;
		byte[] byteImage;
		bool imageSet = false;
		public AddProductPage()
		{
			InitializeComponent();

			product = new Product();

			List<Category> cats = Helper.context.Categories.ToList();
			cbCategory.ItemsSource = cats;
			cbCategory.SelectedValuePath = "Id";
			cbCategory.DisplayMemberPath = "CategoryName";
			cbCategory.SelectedValue = 0;

		


			NewProduct();

		}

		private void NewProduct()
		{
			product = new Product();
			byte[]? pic = Helper.NoImage;
			ProductViewModel pvm = new ProductViewModel();
			pvm.Product = product;
			pvm.ProductPicture = pic!;

			ProductStackPanel.DataContext = pvm;
			tbProductCost.Text = pvm.Price;

			cbCategories_SelectionChanged(null,null);
		}


		public void ButtonChangePicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp;*.tiff;*.jfif;";
			if (ofd.ShowDialog() == true)
			{
				string filePath = ofd.FileName;
				BitmapImage bmp = new BitmapImage(new Uri(filePath));

				JpegBitmapEncoder encoder = new JpegBitmapEncoder();
				encoder.Frames.Add(BitmapFrame.Create(bmp));
				using (MemoryStream ms = new MemoryStream())
				{
					encoder.Save(ms);
					byteImage = ms.ToArray();
				}
				imageProduct.Source = bmp as ImageSource;
				imageSet = true;
			}
		}

		public void ButtonSave_Click(object sender, EventArgs e)
		{
			decimal cost;
			if (!Decimal.TryParse(tbProductCost.Text, out cost))
			{
				MessageBox.Show("Неправильно указана цена!", "Ошибка");
				return;
			}
			int discount;
			if (!int.TryParse(tbDiscount.Text, out discount))
			{
				MessageBox.Show("Неправильно указана скидка!", "Ошибка");
				return;
			}
			int maxDiscount;
			if (!int.TryParse(tbMaxDiscount.Text, out maxDiscount))
			{
				MessageBox.Show("Неправильно указана максимальная скидка!", "Ошибка");
				return;
			}
			if (maxDiscount < discount)
			{
				MessageBox.Show("Указанная скидка больше указанной максимальной скидки!", "Ошибка");
				return;
			}

			product.CategoryId = (int) cbCategory.SelectedValue;
			
			foreach(ProductCharacteristicViewModel item in DataGridCharacteristics.Items)
			{
				if (item.CharValue == "") 
					continue;

				ProductCharacteristic pc = new ProductCharacteristic();
				pc.CharacteristicId = item.Id;
				pc.CharacteristicValue = item.CharValue;
				pc.Unit = item.Unit;
				product.ProductCharacteristics.Add(pc);
			}
			Helper.context.Products.Add(product);
			if (imageSet)
			{
				ProductPicture pp = new ProductPicture();
				pp.Picture = byteImage;
				product.ProductPictures.Add(pp);
			}
			Helper.context.SaveChanges();
			MessageBox.Show("Товар успешно добавлен");
			NewProduct();

		}



		public void cbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			DataGridCharacteristics.ItemsSource = null;
			if (cbCategory.SelectedItem == null)
			{
				return;
			}
			int categoryId = (int) cbCategory.SelectedValue;
			Category cat = Helper.context.Categories.Include(c => c.Characteristics)
										.Where(cat => cat.Id == categoryId).FirstOrDefault()!;

			List<Characteristic> chars = cat.Characteristics.ToList();

			List<ProductCharacteristicViewModel> views = new List<ProductCharacteristicViewModel>();

			foreach (Characteristic characteristic in chars)
			{
				 views.Add(new ProductCharacteristicViewModel(characteristic));
			}
			DataGridCharacteristics.ItemsSource = views;
		}





		public void ButtonGetBack_Click(object sender, EventArgs e)
		{
			this.NavigationService.GoBack();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{

		}
	}
}
