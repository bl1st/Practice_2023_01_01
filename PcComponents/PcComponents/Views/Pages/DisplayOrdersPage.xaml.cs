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
using Microsoft.EntityFrameworkCore.Storage;
using PcComponents.Models.Entities;
using PcComponents.ViewModels;

namespace PcComponents.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для DisplayOrdersPage.xaml
    /// </summary>
    public partial class DisplayOrdersPage : Page
    {
        public DisplayOrdersPage()
        {
            InitializeComponent();
            tbManager.Text = $"{Helper.UserRole}: {Helper.UserName}";
        }

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			InvalidateOrders();
		}

		private void tbOrderId_TextChanged(object sender, TextChangedEventArgs e)
		{
            InvalidateOrders();
        }


        private void InvalidateOrders()
        {
			List<Models.Entities.Order> orders;
			lvOrders.ItemsSource = null;

			string id =  tbOrderId.Text.Trim();
			if (id == "")
			{
				orders = Helper.context.Orders.ToList();
			}
			else
			{
				int intId = 0;
				if (int.TryParse(id,out intId))
				{
					orders = Helper.context.Orders.Where(o => o.Id.ToString().StartsWith(intId.ToString())).ToList();
				}
				else
				{
					orders = Helper.context.Orders.ToList();
				}
			}
			

			
			
			List<OrderViewModel> viewModels = new List<OrderViewModel>();
			foreach (Models.Entities.Order order in orders)
			{
				OrderViewModel ovm = new OrderViewModel(order);
				viewModels.Add(ovm);

			}
			lvOrders.ItemsSource = viewModels;

		}

		private void lvOrders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Models.Entities.Order order;
			try
			{
				ListView? lv = sender as ListView;
				if (lv?.SelectedItem == null) return;
				order = ((OrderViewModel)((sender as ListView)!).SelectedItem).Order;
			}
			catch (Exception ex) { return; }

			this.NavigationService.Navigate(new OrderInformationPage(order));
		}

		private void btnEditOrder_Click(object sender, RoutedEventArgs e)
		{
			Models.Entities.Order order = (Models.Entities.Order)((sender as Button).Tag);
			this.NavigationService.Navigate(new EditOrderInformation(order));
		}
	}
}
