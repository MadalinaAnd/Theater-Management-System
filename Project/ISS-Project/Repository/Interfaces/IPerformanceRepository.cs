using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public interface IPerformanceRepository:IRepository<Performance>
	{
		List<Performance> GetAllPerformancesByDate(string date);
	}
}
