using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("Spectators")]
	public class Spectator
	{
		[Column("id_spectator")]
		public int Id { get; set; }
		[Column("username")]
		public string Username { get; set; }
		[Column("password")]
		public string Password { get; set; }
		[Column("email")]
		public string Email { get; set; }

		public Spectator()
		{
			Id = 0;
			Username = "";
			Password = "";
			Email = "";
		}
		public Spectator( string username, string password, string email)
		{
			Id = 0;
			Username = username;
			Password = password;
			Email = email;
		}
		public Spectator(int idSpectator, string username, string password, string email)
		{
			Id = idSpectator;
			Username = username;
			Password = password;
			Email = email;
		}
	}
}
