using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class PerformanceRepository : IPerformanceRepository
	{
		private readonly PerformanceContext performanceContext;

		public PerformanceRepository(PerformanceContext performanceContext)
		{
			this.performanceContext = performanceContext;
		}

		public void Add(Performance entity)
		{
			var response = performanceContext.Add(entity);
			performanceContext.SaveChanges();
		}

		public void Delete(int id)
		{
			performanceContext.Remove(Find(id));
			performanceContext.SaveChanges();
		}

		public Performance Find(int id)
		{
			return performanceContext.Performances.Where(e => e.Id == id).FirstOrDefault();
		}

		public List<Performance> GetAll()
		{
			return performanceContext.Performances.ToList();
		}

		private string GetDate(string date)
		{
			var d = date.Split('-');
			var finalDate = d[0] + '-' + d[1] + '-' + d[2];
			return finalDate;
		}

		public List<Performance> GetAllPerformancesByDate(string date)
		{
			var performances = performanceContext.Performances.ToList();
			var per = new List<Performance>();
			foreach(var p in performances)
			{
				if(GetDate(p.Date) == date)
				{
					per.Add(p);
				}
			}
			return per;
		}

		public void Update(Performance entity)
		{
			var result = Find(entity.Id);
			result.Name = entity.Name;
			result.Date = entity.Date;
			performanceContext.SaveChanges();
		}
	}
}
