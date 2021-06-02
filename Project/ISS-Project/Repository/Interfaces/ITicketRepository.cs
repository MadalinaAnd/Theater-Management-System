using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public interface ITicketRepository:IRepository<Ticket>
	{
		List<Ticket> GetAllTicketsByUser(int id);
		List<Ticket> GetAllTicketsFromDate( string date);
	}
}
