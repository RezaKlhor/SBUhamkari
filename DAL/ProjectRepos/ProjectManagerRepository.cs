using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.ProjectRepos
{

    public class ProjectManagerRepository : Repository<ProjectManager>, IProjectManagerRepository
    {
        public ProjectManagerRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<ProjectManager> GetProjectManagersByManagerRoleWithProject(Guid roleID)
        {
            return HamkariContext.ProjectManagers.Where<ProjectManager>
                (m => m.User.Role.id == roleID).Include(m => m.Project).ToList();
        }

        public List<ProjectManager> GetProjectManagersByManagerWithProject(Guid managerID)
        {
            return HamkariContext.ProjectManagers.Where(m => m.User.id == managerID).Include(m => m.Project).ToList();
        }
    }
}
