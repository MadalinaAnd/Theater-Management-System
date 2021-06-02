using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public class Service : IService
	{
		IAdminRepository adminRepository;
		IPerformanceRepository performanceRepository;
		IReservedSeatRepositoy reservedSeatRepositoy;
		ISpectatorRepository spectatorRepository;
		ITicketRepository ticketRepository;

		public Service(IAdminRepository adminRepository, IPerformanceRepository performanceRepository, IReservedSeatRepositoy reservedSeatRepositoy, ISpectatorRepository spectatorRepository, ITicketRepository ticketRepository)
		{
			this.adminRepository = adminRepository;
			this.performanceRepository = performanceRepository;
			this.reservedSeatRepositoy = reservedSeatRepositoy;
			this.spectatorRepository = spectatorRepository;
			this.ticketRepository = ticketRepository;
		}

		public void AddAdmin(Admin admin)
		{
			adminRepository.Add(admin);
		}

		public void AddPerformance(Performance performance)
		{
			performanceRepository.Add(performance);
		}

		public void AddReservedSeat(ReservedSeat reservedSeat)
		{
			reservedSeatRepositoy.Add(reservedSeat);
		}

		public void AddSpectator(Spectator spectator)
		{
			spectatorRepository.Add(spectator);
		}

		public void AddTicket(Ticket ticket)
		{
			ticketRepository.Add(ticket);
		}

		public void DeleteAdmin(int id)
		{
			adminRepository.Delete(id);
		}

		public void DeletePerformance(int id)
		{
			performanceRepository.Delete(id);
		}

		public void DeleteReservedSeat(int id)
		{
			reservedSeatRepositoy.Delete(id);
		}

		public void DeleteSpectator(int id)
		{
			spectatorRepository.Delete(id);
		}

		public void DeleteTicket(int id)
		{
			ticketRepository.Delete(id);
		}

		public List<Admin> GetAllAdmins()
		{
			return adminRepository.GetAll();
		}

		public List<Performance> GetAllPerformances()
		{
			return performanceRepository.GetAll();
		}

		public List<Performance> GetAllPerformancesByDate(string date)
		{
			return performanceRepository.GetAllPerformancesByDate(date);
		}

		public List<ReservedSeat> GetAllReservedSeats()
		{
			return reservedSeatRepositoy.GetAll();
		}

		public List<ReservedSeat> GetAllReservedTicketsByUser(int id)
		{
			return reservedSeatRepositoy.GetAllReservedTicketsByUser(id);
		}

		public List<ReservedSeat> GetAllReservedTicketsByUserFromDate(int id, string date)
		{
			return reservedSeatRepositoy.GetAllReservedTicketsFromDate(date);
		}

		public List<Spectator> GetAllSpectators()
		{
			return spectatorRepository.GetAll();
		}

		public List<Ticket> GetAllTickets()
		{
			return ticketRepository.GetAll();
		}

		public List<Ticket> GetAllTicketsByUser(int id)
		{
			return ticketRepository.GetAllTicketsByUser(id);
		}

		public List<Ticket> GetAllTicketsByUserFromDate(int id, string date)
		{
			return ticketRepository.GetAllTicketsFromDate(date);
		}

		public Admin LogInAdmin(string username, string password)
		{
			Admin admin = adminRepository.FindByUsername(username);

			if (admin != null  && password == admin.Password)
			{
				return admin;
			}
			return null;
		}

		public Spectator LogInSpectator(string username, string password)
		{
			Spectator spectator = spectatorRepository.FindByUsername(username);

			if (spectator != null && password == spectator.Password)
			{
				return spectator;
			}
			return null;
		}

		public void UpdatePerformance(Performance performance)
		{
			performanceRepository.Update(performance);
		}
	}
}
