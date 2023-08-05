using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Models
{
	public class User : IUser
	{
		public User(int id, string username, string password, string email)
		{
			Id = id;
			Username = username;
			Password = password;
			Email = email;
		}

		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
	}
}
