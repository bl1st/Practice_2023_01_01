using PcComponents.Models.Entities;
using PcComponents.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcComponents.Services
{
	public class ProductCreation
	{
		private Product _product;
		private ProductCharacteristic[] _chars;


		public ProductCreation(Product product, params ProductCharacteristic[] characteristics)
		{
			_product = product;
			_chars = characteristics;

		}

		public bool AddProduct()
		{
			if (_product == null) { return false; }
			if (_chars == null ) { return false; }
			if (_chars.Length == 0 ) { return false; }

			foreach (ProductCharacteristic pc in _chars)
			{
				_product.ProductCharacteristics.Add(pc);
			}
			
			Helper.context.Products.Add(_product);
			try
			{
				Helper.context.SaveChanges();

			}
			catch (Exception ex) { return false; }
			
			return true;
		}


	}
}
