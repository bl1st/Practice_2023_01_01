using PcComponents.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcComponents.ViewModels
{
    public class OrderedProductViewModel
    {
		public OrderedProduct OrderedProduct { get; set; } = null!;

		public byte[]? ProductPicture { get; set; }

		public string Category { get; set; } = null!;
		
		public string ProductName { get; set; } = null!;

		public int ProductId { get; set; }


		public string Price
		{
			get
			{
				return OrderedProduct.Product.Price.ToString("0.####");
			}
		}
		public double CostWithDiscount
		{
			get
			{
				double priceWithoutDiscount = (double)OrderedProduct.Product.Price;
				double discountAmount = (double)OrderedProduct.Product.Price * (Discount / 100.0);
				double priceWithDiscount = priceWithoutDiscount - discountAmount;
				return priceWithDiscount;

			}
		}
		public int Discount { get; set; }




		public OrderedProductViewModel(OrderedProduct op)
		{
			this.OrderedProduct = op;
			byte[]? pic = Helper.context.ProductPictures.Where(pp => pp.ProductId == op.Product.Id).FirstOrDefault()?.Picture;
			if (pic == null)
				pic = Helper.NoImage;
			Category? cat = Helper.context.Categories.Find(op.Product.CategoryId);

			this.Category = cat!.CategoryName;
			this.ProductPicture = pic!;

			this.ProductName = op.Product.Name;
			this.Discount = op.Product.Discount;
			this.ProductId = OrderedProduct.Product.Id;
		}


	}
}
