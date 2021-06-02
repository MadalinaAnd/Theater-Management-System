using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("Tickets")]
	public class Ticket
	{
		[Column("id_ticket")]
		public int Id { get; set; }
		[Column("id_performance")]
		public int IdPerformance { get; set; }
		[Column("name")]
		public string Name { get; set; }
		[Column("seat")]
		public int Seat { get; set; }
		[Column("price")]
		public double Price { get; set; }
		[Column("date")]
		public string Date { get; set; }
		[Column("id_user")]
		public int IdUser { get; set; }


		public Ticket()
		{
			Id = 0;
			IdPerformance = 0;
			Name = "";
			Seat = 0;
			Price = 0;
			Date = "";
			IdUser = 0;
		}

		public Ticket(int idPerformance, string name, int seat, double price, string date, int idUser)
		{
			Id = 0;
			IdPerformance = idPerformance;
			Name = name;
			Seat = seat;
			Price = price;
			Date = date;
			IdUser = idUser;
		}

		public Ticket(int id, int idPerformance, string name, int seat, double price, string date, int idUser)
		{
			Id = id;
			IdPerformance = idPerformance;
			Name = name;
			Seat = seat;
			Price = price;
			Date = date;
			IdUser = idUser;
		}
	}
}
