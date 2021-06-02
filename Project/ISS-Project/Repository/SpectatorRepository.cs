using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class SpectatorRepository : ISpectatorRepository
	{
		private readonly SpectatorContext spectatorContext;

		public SpectatorRepository(SpectatorContext spectatorContext)
		{
			this.spectatorContext = spectatorContext;
		}

		public void Add(Spectator entity)
		{
			var response = spectatorContext.Add(entity);
			spectatorContext.SaveChanges();
		}

		public void Delete(int id)
		{
			spectatorContext.Remove(Find(id));
			spectatorContext.SaveChanges();
		}

		public Spectator Find(int id)
		{
			return spectatorContext.Spectators.Where(e => e.Id == id).FirstOrDefault();
		}

		public Spectator FindByUsername(string username)
		{
			return spectatorContext.Spectators.Where(e => e.Username == username).FirstOrDefault();
		}

		public List<Spectator> GetAll()
		{
			return spectatorContext.Spectators.ToList();
		}

		public void Update(Spectator entity)
		{
			var result = Find(entity.Id);
			result.Username = entity.Username;
			result.Password = entity.Password;
			result.Email = entity.Email;
			spectatorContext.SaveChanges();
		}
	}
}
