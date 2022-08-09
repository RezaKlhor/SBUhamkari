using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public Guid GetRoleID(string role)
        {
            return SingleOrDefault(m => m.Name == role).id;
        }
    }
}
