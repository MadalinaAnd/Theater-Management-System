using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("Performances")]
	public class Performance
	{
		[Column("id_performance")]
		public int Id { get; set; }
		[Column("name")]
		public string Name { get; set; }
		[Column("date")]
		public string Date { get; set; }
		[Column("price")]
		public int Price { get; set; }

		public Performance()
		{
			Id = 0;
			Name = "";
			Date = "";
			Price = 0;
		}

		public Performance(string name, string data, int price)
		{
			Id = 0;
			Name = name;
			Date = data;
			Price = price;
		}

		public Performance(int id, string name, string data, int price)
		{
			Id = id;
			Name = name;
			Date = data;
			Price = price;
		}
	}
}
