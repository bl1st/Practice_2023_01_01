using PcComponents.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcComponents.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; } = null!;

        public byte[]? ProductPicture { get; set; }

		public string Category { get; set; } = null!;
        public int Position { get; set; }

        public string Price
        {
            get
            {
                return Product.Price.ToString("0.####");
            }
        }
		public double CostWithDiscount
		{
			get
			{
				double priceWithoutDiscount = (double)Product.Price;
				double discountAmount = (double)Product.Price * (Product.Discount / 100.0);
				double priceWithDiscount = priceWithoutDiscount - discountAmount;
				return priceWithDiscount;

			}
		}
	}
}
