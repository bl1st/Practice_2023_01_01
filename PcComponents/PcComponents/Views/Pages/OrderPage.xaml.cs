using PcComponents.Models.Entities;
using PcComponents.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        MainView parent;
        public OrderPage(MainView mv)
        {
            this.parent = mv;
            InitializeComponent();

            InvalidateList();

            cbOutposts.ItemsSource = (Helper.context.Outposts.ToList());
            cbOutposts.DisplayMemberPath = "Address";
            cbOutposts.SelectedValuePath = "Id";
            cbOutposts.SelectedIndex = 0;
            string fio = Helper.UserName == "" ? "Гость" : Helper.UserName;
            tbFIO.Text = $"Имя клиента: {fio}";
        }

		private void orderProductList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			int productId;
			try
			{
				ListView? lv = sender as ListView;
				if (lv?.SelectedItem == null) return;
				productId = ((OrderedProductViewModel)((sender as ListView)!).SelectedItem).OrderedProduct.Product.Id;
			}
			catch (Exception ex) { return; }

            this.NavigationService.Navigate(new ProductInformationPage(productId));
		}

        public void RecalculateCost()
        {
            double totalPrice = 0;
            foreach (OrderedProduct op in Order.Products)
            {
                double priceWithoutDiscount = (double)op.Product.Price;
                double discountAmount = (double)op.Product.Price * (op.Product.Discount / 100.0);
                double priceWithDiscount = priceWithoutDiscount - discountAmount;
                totalPrice += priceWithDiscount * op.Quantity;
            }
            tbCost.Text = "Итоговая стоимость: " + Math.Round(totalPrice,2).ToString() + " руб.";
        }

        public void InvalidateList()
        {
            orderProductList.ItemsSource = null;
            List<OrderedProductViewModel> listOrderedProducts = new List<OrderedProductViewModel>();
			foreach (OrderedProduct op in Order.Products)
            {
                OrderedProductViewModel opvm = new OrderedProductViewModel(op);            		
                listOrderedProducts.Add(opvm);

			}
            if (listOrderedProducts.Count <= 0)
            {
                textBlockProductsHeader.Text = "Корзина пуста. Нет товаров";
            }
            else
            {
				textBlockProductsHeader.Text = "Список товаров в корзине";
			}
            orderProductList.ItemsSource = listOrderedProducts;
            RecalculateCost();
		}

		private void plusProduct_Click(object sender, RoutedEventArgs e)
		{
            int id = (int)(sender as Button)!.Tag;
            OrderedProduct op = Order.Products.Where(oProduct => oProduct.Product.Id == id).FirstOrDefault()!;
            op.Quantity++;
            InvalidateList();
		}

		private void minusProduct_Click(object sender, RoutedEventArgs e)
		{
			int id = (int)(sender as Button)!.Tag;
			OrderedProduct op = Order.Products.Find(p => p.Product.Id == id)!;
			op.Quantity--;
            if (op.Quantity <= 0)
                Order.RemoveProduct(id);
			string cartButtonText = "Корзина";
			if (Order.Products.Count > 0)
			{
				cartButtonText += $": ({Order.Products.Count})";
			}
			parent.textBlockCart.Text = cartButtonText;
			InvalidateList();
		}

        private void tbProductQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox TextBox = (sender as TextBox)!;
            int id = (int)TextBox.Tag;
            OrderedProduct op = Order.Products.Where(op => op.Product.Id == id).FirstOrDefault()!;

            int quantity = 0;
            if (int.TryParse(TextBox.Text, out quantity))
            {
				op.Quantity = quantity;
				RecalculateCost();
			}
            return;
        }

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
            InvalidateList();
		}

        private void ButtonSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (orderProductList.Items.Count <= 0 )
            {
                MessageBox.Show("Корзина пуста!");
                return;
            }
			PcComponents.Models.Entities.Order order = new PcComponents.Models.Entities.Order();
            order.StatusId = 1;
            order.OutpostId = (int) cbOutposts.SelectedValue;
            order.OrderDate = DateTime.Now;
            order.DeliveryDate = DateTime.Now.AddDays(7);
            order.RecieveCode = Helper.context.Orders.Max(o => o.RecieveCode) + 1;
            order.ClientFullName = Helper.UserName;
            order.Id = Helper.context.Orders.Max(o => o.Id) +1;

            Helper.context.Orders.Add(order);
            Helper.context.SaveChanges();

            foreach (OrderedProduct op in Order.Products)
            {
                OrderContent oc = new OrderContent();
                oc.ProductId = op.Product.Id;
                oc.OrderId = order.Id;
                oc.Quantity = op.Quantity;
                Helper.context.OrderContents.Add(oc);
            }
			Helper.context.SaveChanges();
            MessageBox.Show("Ваш заказ оформлен\nЧерез 7 календарных дней можете забрать заказ в пункте выдачи\nНомер для полуения заказа: "+ order.RecieveCode);
            Order.Products = new List<OrderedProduct>();
            NavigationService.GoBack();
		}

		private void tbProductQuantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			try
			{
				Convert.ToInt32(e.Text);
			}
			catch
			{
				e.Handled = true;
			}
		}
	}
}
