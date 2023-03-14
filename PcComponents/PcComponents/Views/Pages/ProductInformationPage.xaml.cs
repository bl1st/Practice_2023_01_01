using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.AuthScheme.PoP;
using PcComponents.Models.Entities;
using PcComponents.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
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
	/// Логика взаимодействия для ProductInformationPage.xaml
	/// </summary>
	public partial class ProductInformationPage : Page
	{
		public ProductInformationPage(int productId)
		{
			InitializeComponent();

			Product p = Helper.context.Products.Find(productId)!;

			byte[]? pic = Helper.context.ProductPictures.Where(pp => pp.ProductId == p.Id).FirstOrDefault()?.Picture;
			Category? cat = Helper.context.Categories.Find(p.CategoryId);
			ProductViewModel pvm = new ProductViewModel();
			pvm.Product = p;
			pvm.Category = cat!.CategoryName;
			pvm.ProductPicture = pic;
			stackProductInfo.DataContext = pvm;


			this.Title = p.Name;

			List<ProductCharacteristic> productChars = Helper.context.ProductCharacteristics.Include(pc => pc.Characteristic).Where(pch => pch.ProductId == p.Id).ToList();
			foreach (ProductCharacteristic chars in productChars)
			{
				lvChars.Items.Add(chars);			
			}
			


		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.GoBack();
		}
	}
}
