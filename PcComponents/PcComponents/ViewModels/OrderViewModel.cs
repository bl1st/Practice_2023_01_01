using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using PcComponents.Models.Entities;

namespace PcComponents.ViewModels
{
    class OrderViewModel
    {
        public Models.Entities.Order Order { get; set; }
        public string OrderCreationDate
        {
            get => Order.OrderDate.ToShortDateString();
        }
		public string OrderDeliveryDate
		{
			get => Order.DeliveryDate.ToShortDateString();
		}
        
        public System.Windows.Visibility VisibilityState
        {
            get => Order.Status.Name.Trim() == "Завершен" ? Visibility.Hidden : Visibility.Visible;
        }

		public OrderViewModel(Models.Entities.Order order)
        {
            this.Order = order;
        }


    }
}
