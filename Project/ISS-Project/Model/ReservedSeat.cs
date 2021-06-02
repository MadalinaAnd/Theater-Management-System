using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("ReservedSeats")]
	public class ReservedSeat
	{
		[Column("id_reservedSeats")]
		public int Id { get; set; }
		[Column("id_performance")]
		public int IdPerformance { get; set; }
		[Column("id_user")]
		public int IdUser { get; set; }
		[Column("name")]
		public string Name { get; set; }
		[Column("seat")]
		public int Seat { get; set; }
		[Column("price")]
		public double Price { get; set; }
		[Column("date")]
		public string Date { get; set; }

		public ReservedSeat(int id, int idPerformance, int idUser, string name, int seat, double price, string date)
		{
			Id = id;
			IdPerformance = idPerformance;
			IdUser = idUser;
			Name = name;
			Seat = seat;
			Price = price;
			Date = date;
		}

		public ReservedSeat( int idPerformance, int idUser, string name, int seat, double price, string date)
		{
			Id = 0;
			IdPerformance = idPerformance;
			IdUser = idUser;
			Name = name;
			Seat = seat;
			Price = price;
			Date = date;
		}
		public ReservedSeat()
		{
			Id = 0;
			IdPerformance = 0;
			IdUser = 0;
			Name = "";
			Seat = 0;
			Price = 0;
			Date = "";
		}
	}

}
