using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface IRoleRepository : IRepository<Role>
    {
        Guid GetStudentRoleID(string role);
    }
}
