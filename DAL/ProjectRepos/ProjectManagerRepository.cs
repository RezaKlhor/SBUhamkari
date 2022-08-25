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

        public ProjectManager GetProjectManagerByUserAndProject(Guid userId, Guid projectId)
        {
            return HamkariContext.ProjectManagers.Where(m => m.User.id == userId && m.Project.id == projectId).FirstOrDefault();
        }

        public List<ProjectManager> GetProjectManagersByManagerRoleWithProject(Guid roleID)
        {
            return HamkariContext.ProjectManagers.Where<ProjectManager>
                (m => m.User.Role.id == roleID).Include(m => m.Project).ToList();
        }

        public List<ProjectManager> GetProjectManagersByManagerWithProject(Guid managerID)
        {
            var projectmanager = HamkariContext.ProjectManagers.Include(m=> m.User).Where(m=>m.User.id==managerID).ToList();
            return HamkariContext.ProjectManagers.Where(m => m.User.id == managerID).Include(m => m.Project).ToList();
        }

        public List<User> GetProjectManagersByProject(Guid projectId)
        {
            return HamkariContext.ProjectManagers.Include(m => m.User).Include(m => m.Project).Where(m => m.Project.id == projectId).Select(m => m.User).ToList();
        }
    }
}
