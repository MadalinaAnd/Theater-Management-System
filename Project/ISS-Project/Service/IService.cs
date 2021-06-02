using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public interface IService
	{
		Admin LogInAdmin(string username, string password);
		Spectator LogInSpectator(string username, string password);

		void AddAdmin(Admin admin);
		void AddSpectator(Spectator spectator);
		void AddTicket(Ticket ticket);
		void AddPerformance(Performance performance);
		void AddReservedSeat(ReservedSeat reservedSeat);

		void DeleteAdmin(int id);
		void DeleteSpectator(int id);
		void DeleteTicket(int id);
		void DeletePerformance(int id);
		void DeleteReservedSeat(int id);

		void UpdatePerformance(Performance performance);

		List<Admin> GetAllAdmins();
		List<Spectator> GetAllSpectators();
		List<Ticket> GetAllTickets(); 
		List<Performance> GetAllPerformances(); 
		List<ReservedSeat> GetAllReservedSeats();

		List<Performance> GetAllPerformancesByDate(string date);
		List<ReservedSeat> GetAllReservedTicketsByUser(int id);
		List<Ticket> GetAllTicketsByUser(int id);
		List<ReservedSeat> GetAllReservedTicketsByUserFromDate(int id, string date);
		List<Ticket> GetAllTicketsByUserFromDate(int id, string date);

	}
}
