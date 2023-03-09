using PcComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcComponents.Services;
using PcComponents.Models.Entities;

namespace TestProject
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void Get_ExistingUser()
		{
			string login = "o@outlook.com";
			string password = "2L6KZG";
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			int expectedId = 1;
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
		public void Get_User_With_Not_Existing_Login()
		{
			string login = "THIS_LOGIN_DOES_NOT_EXIST_IN_DATABASE";
			string password = "DASDSAD";
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			Assert.AreEqual(usr, null);
		}
		[TestMethod]
		public void Get_Null_User_By_Sending_Null_Login_String()
		{
			string login = null!;
			string password = "DASDSAD";
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			Assert.AreEqual(usr, null);
		}
		[TestMethod]
		public void Get_User_Send_Extemely_Large_Password()
		{
			string login = "";
			string password = "ASDHAGSDKJDSLLHIDJHYUIIDGHJUSYAGDSHDUAYGDSKHDKJSADUTURYSAIGDHASUYASDHAGSDKJDSLLHIDJHYUIIDGHJUSYAGDSHDUAYGDSKHDKJSADUTURYSAIGDHASUY";
			password += "ASDHAGSDKJDSLLHIDJHYUIIDGHJUSYAGDSHDUAYGDSKHDKJSADUTURYSAIGDHASUY&DT^USAGDHUASYTUDIAGSHDASYDGHJDAS";
			AuthorizationModule am = new AuthorizationModule(login, password);
			User usr = am.Authorize();
			Assert.AreEqual(usr, null);
		}
	}
}