using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public interface IReservedSeatRepositoy : IRepository<ReservedSeat>
	{
		List<ReservedSeat> GetAllReservedTicketsByUser(int id);
		List<ReservedSeat> GetAllReservedTicketsFromDate(string date);
	}
}
