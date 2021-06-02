using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class AdminRepository : IAdminRepository
	{
		private readonly AdminContext adminContext;

		public AdminRepository(AdminContext adminContext)
		{
			this.adminContext = adminContext;
		}

		public void Add(Admin entity)
		{
			var response = adminContext.Add(entity);
			adminContext.SaveChanges();
		}

		public void Delete(int id)
		{
			adminContext.Remove(Find(id));
			adminContext.SaveChanges();
		}

		public Admin Find(int id)
		{
			return adminContext.Admins.Where(e => e.Id == id).FirstOrDefault();
		}

		public Admin FindByUsername(string username)
		{
			return adminContext.Admins.Where(e => e.Username == username).FirstOrDefault();
		}

		public List<Admin> GetAll()
		{
			return adminContext.Admins.ToList();
		}

		public void Update(Admin entity)
		{
			var result = Find(entity.Id);
			result.Username = entity.Username;
			result.Password = entity.Password;
			adminContext.SaveChanges();
		}
	}
}
