using System;
using System.Linq;

namespace QRCodeAPI.Models
{
	public class UserValidate
	{
		public static bool Login(string username, string password)
		{
			Users users = new Users();
			var list = users.GetUsers();
			return list.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password);
		}
	}
}