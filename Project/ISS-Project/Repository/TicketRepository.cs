using Model;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
	public class TicketRepository : ITicketRepository
	{
		private readonly TicketContext ticketContext;

		public TicketRepository(TicketContext ticketContext)
		{
			this.ticketContext = ticketContext;
		}

		public void Add(Ticket entity)
		{
			var response = ticketContext.Add(entity);
			ticketContext.SaveChanges();
		}

		public void Delete(int id)
		{
			ticketContext.Remove(Find(id));
			ticketContext.SaveChanges();
		}

		public Ticket Find(int id)
		{
			return ticketContext.Tickets.Where(e => e.Id == id).FirstOrDefault();
		}

		public List<Ticket> GetAll()
		{
			return ticketContext.Tickets.ToList();
		}

		public List<Ticket> GetAllTicketsByUser(int id)
		{
			return ticketContext.Tickets.Where(e => e.IdUser == id).ToList();
		}

		public void Update(Ticket entity)
		{
			var result = Find(entity.Id);
			result.IdPerformance = entity.IdPerformance;
			result.Name = entity.Name;
			result.Seat = entity.Seat;
			result.Price = entity.Price;
			result.Date = entity.Date;
			result.IdUser = entity.IdUser;
			ticketContext.SaveChanges();
		}

		private string GetDate(string date)
		{
			var d = date.Split('-');
			var finalDate = d[0] + '-' + d[1] + '-' + d[2];
			return finalDate;
		}

		List<Ticket> ITicketRepository.GetAllTicketsFromDate( string date)
		{
			var li = ticketContext.Tickets.ToList();
			var tickets = new List<Ticket>();
			foreach (var l in li)
			{
				if (GetDate(l.Date) == date)
				{
					tickets.Add(l);
				}
			}
			return tickets;
		}
	}
}
