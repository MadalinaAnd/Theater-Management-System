using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class ReservedSeatRepositoy : IReservedSeatRepositoy
	{
		private readonly ReservedSeatContext reservedSeatContext;

		public ReservedSeatRepositoy(ReservedSeatContext reservedSeatContext)
		{
			this.reservedSeatContext = reservedSeatContext;
		}

		public void Add(ReservedSeat entity)
		{
			var response = reservedSeatContext.Add(entity);
			reservedSeatContext.SaveChanges();
		}

		public void Delete(int id)
		{
			reservedSeatContext.Remove(Find(id));
			reservedSeatContext.SaveChanges();
		}

		public ReservedSeat Find(int id)
		{
			return reservedSeatContext.ReservedSeats.Where(e => e.Id == id).FirstOrDefault();
		}

		public List<ReservedSeat> GetAll()
		{
			return reservedSeatContext.ReservedSeats.ToList();
		}

		public List<ReservedSeat> GetAllReservedTicketsByUser(int id)
		{
			return reservedSeatContext.ReservedSeats.Where(e => e.IdUser == id).ToList();
		}

		private string GetDate(string date)
		{
			var d = date.Split('-');
			var finalDate = d[0] + '-' + d[1] + '-' + d[2];
			return finalDate;
		}

		public List<ReservedSeat> GetAllReservedTicketsFromDate(string date)
		{
			var li = reservedSeatContext.ReservedSeats.ToList();
			var tickets = new List<ReservedSeat>();
			foreach(var l in li)
			{
				if (GetDate(l.Date) == date)
				{
					tickets.Add(l);
				}
			}
			return tickets;
		}

		public void Update(ReservedSeat entity)
		{
			var result = Find(entity.Id);
			result.IdPerformance = entity.IdPerformance;
			result.Name = entity.Name;
			result.Seat = entity.Seat;
			result.Price = entity.Price;
			result.Date = entity.Date;
			result.IdUser = entity.IdUser;
			reservedSeatContext.SaveChanges();
		}
	}
}
