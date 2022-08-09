using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface IProjectManagerRepository : IRepository<ProjectManager>
    {
        List<ProjectManager> GetProjectManagersByManagerWithProject(Guid managerID);
        List<ProjectManager> GetProjectManagersByManagerRoleWithProject(Guid roleID);

    }
}
