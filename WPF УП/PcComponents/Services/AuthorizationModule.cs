using PcComponents.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcComponents.Services
{
	public class AuthorizationModule
	{
		public string Login { get; set; }
		public string Password { get; set; }
		public AuthorizationModule(string login, string password)
		{
			this.Login = login;
			this.Password = password;
		}

		public User Authorize()
		{
			User usr = Helper.context.Users.Where(u => u.Login == this.Login && u.Password == this.Password).FirstOrDefault()!;
			return usr;
		}


	}
}
