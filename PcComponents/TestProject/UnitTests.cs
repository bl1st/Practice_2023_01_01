using PcComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcComponents.Services;
using PcComponents.Models.Entities;
using PcComponents.Views;
using System.Windows.Controls;
using PcComponents.Views.Pages;

namespace TestProject
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void Get_ExistingUser()
		{
			string login = "19dn@outlook.com";
			string password = "RSbvHv";
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			int expectedId = 5;
			Assert.AreEqual(usr.Id, expectedId);
		}
		[TestMethod]
		public void Get_User_With_Wrong_Password()
		{
			string login = "o@outlook.com";
			string password = "DASDSAD";
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			Assert.AreEqual(usr, null);
		}

		[TestMethod]
		public void Get_User_Send_Extemely_Large_Password()
		{
			string login = "o@outlook.com";
			string password = "ASDHAGSDKJDSLLHIDJHYUIIDGHJUSYAGDSHDUAYGDSKHDKJSADUTURYSAIGDHAS" +
				"UYADJASDHKJDHGLASKJDHASUDGKJDASGHLDJASDUGASHBDASJDADHJSDHAS" +
				"SDHAGSDKJDSLLHIDJHYUIIDGHJUSYAGDSHDUAYGDSKHDKJSADUTURYSAIGDHASUY" +
				"DJASHDJSAHGASLDJAGYDIHASJDHUASGDHSADHASDKAGSJDASHDKHAS" +
				"DJHDGASLDGKLSAJDHDGSSTYDUGHADSJDSA";
		
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			Assert.AreEqual(usr, null);
		}

		[TestMethod]
		public void Create_New_Product()
		{
			Product p = new Product();
			p.Name = "Процессор Intel Core I7 7600K";
			p.MaximumDiscount = 14;
			p.Discount = 4;
			p.Price = 23000;
			p.CategoryId = 1;

			ProductCharacteristic pc = new ProductCharacteristic();
			pc.CharacteristicId = 1; //Brand
			pc.CharacteristicValue = "Intel";
			p.ProductCharacteristics.Add(pc);
			pc.CharacteristicId = 2; //Model
			pc.CharacteristicValue = "I7 7600K";
			p.ProductCharacteristics.Add(pc);

			ProductCreation productCreation = new ProductCreation(p, pc);
			bool result = productCreation.AddProduct();

			Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void Create_New_Product_Without_Characteristics()
		{
			Product p = new Product();
			p.Name = "Процессор Intel Core I7 7600K";
			p.MaximumDiscount = 14;
			p.Discount = 4;
			p.Price = 23000;
			p.CategoryId = 1;

			ProductCharacteristic pc = new ProductCharacteristic();
			pc.CharacteristicId = 1;
			pc.CharacteristicValue = "Intel";
			p.ProductCharacteristics.Add(pc);

			ProductCreation productCreation = new ProductCreation(p, null);
			bool result = productCreation.AddProduct();

			Assert.AreEqual(false, result);
		}







	}
}