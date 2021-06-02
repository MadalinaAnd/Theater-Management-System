using Model;

namespace Repository
{
	public interface IAdminRepository : IRepository<Admin>
	{
		Admin FindByUsername(string username);
	}
}
