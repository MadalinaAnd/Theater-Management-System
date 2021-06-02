using Model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS_Project
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var connectionString = "Data Source = DESKTOP-LQD8TTU\\SQLEXPRESS; Initial Catalog = Theather; Integrated Security = True";


			IAdminRepository adminRepository = new AdminRepository(new AdminContext(connectionString));
			IPerformanceRepository performanceRepository = new PerformanceRepository(new PerformanceContext(connectionString));
			IReservedSeatRepositoy reservedSeatRepositoy = new ReservedSeatRepositoy(new ReservedSeatContext(connectionString));
			ISpectatorRepository spectatorRepository = new SpectatorRepository(new SpectatorContext(connectionString));
			ITicketRepository ticketRepository = new TicketRepository(new TicketContext(connectionString));
			IService service = new Service.Service(adminRepository, performanceRepository, reservedSeatRepositoy, spectatorRepository, ticketRepository);

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LogInForm(service));
		}
	}
}
