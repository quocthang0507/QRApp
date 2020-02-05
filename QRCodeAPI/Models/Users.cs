using System.Collections.Generic;

namespace QRCodeAPI.Models
{
	public class Users
	{
		public List<User> GetUsers()
		{
			List<User> list = new List<User>();
			list.Add(new User()
			{
				ID = 1,
				Username = "laquocthang",
				Password = "laquocthang"
			});
			list.Add(new User()
			{
				ID = 2,
				Username = "admin",
				Password = "admin"
			});
			return list;
		}
	}
}