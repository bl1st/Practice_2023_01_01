﻿using PcComponents.Models.Entities;
using PcComponents.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для EditOrderInformation.xaml
    /// </summary>
    public partial class EditOrderInformation : Page
    {
		private Models.Entities.Order order;
		public EditOrderInformation(Models.Entities.Order order)
		{
			this.order = order;
			InitializeComponent();
			OrderViewModel ovm = new OrderViewModel(order);
			PanelOrderInfo.DataContext = ovm;


			List<OrderContent> contents = Helper.context.OrderContents.Where(oc => oc.OrderId == order.Id).ToList();
			List<int> ids = new List<int>();
			foreach (OrderContent oc in contents)
			{
				ids.Add(oc.ProductId);
			}
			List<Product> products = Helper.context.Products.Where(p => ids.Contains(p.Id)).ToList();

			List<OrderedProduct> orderedProducts = new List<OrderedProduct>();
			foreach (Product p in products)
			{
				OrderContent oc = contents.Find(c => c.ProductId == p.Id)!;
				OrderedProduct op = new OrderedProduct(p, oc.Quantity);
				orderedProducts.Add(op);
			}
			if (orderedProducts.Count == 0)
			{
				tbProductsQuantity.Text = "Товаров нет";
			}
			else
			{
				tbProductsQuantity.Text = $"Кол-во товаров: {orderedProducts.Count} шт.";
			}
			List<OrderedProductViewModel> viewModels = new List<OrderedProductViewModel>();
			foreach (OrderedProduct op in orderedProducts)
			{
				OrderedProductViewModel opvm = new OrderedProductViewModel(op);
				viewModels.Add(opvm);
			}
			orderProductList.ItemsSource = viewModels;

			cbOrderStatus.ItemsSource = Helper.context.OrderStatuses.ToList();
			cbOrderStatus.DisplayMemberPath = "Name";
			cbOrderStatus.SelectedValuePath = "Id";
			cbOrderStatus.SelectedValue = order.StatusId;
		}

		
		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.GoBack();
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			order.StatusId = (int) cbOrderStatus.SelectedValue;
			Helper.context.SaveChanges();
			MessageBox.Show("Информация о заказе изменена");
		}
	}
}
