using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
	[Table("Admins")]
	public class Admin
	{
		[Column("id_admin")]
		public int Id { get; set; }
		[Column("username")]
		public string Username { get; set; }
		[Column("password")]
		public string Password { get; set; }

		public Admin()
		{
			Id = 0;
			Username = "";
			Password = "";
		}

		public Admin(string username, string password)
		{
			Id = 0;
			Username = username;
			Password = password;
		}

		public Admin(int id, string username, string password)
		{
			Id = id;
			Username = username;
			Password = password;
		}
	}
}
