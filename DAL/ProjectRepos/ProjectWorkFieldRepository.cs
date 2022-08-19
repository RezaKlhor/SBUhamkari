using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.ProjectRepos
{
    public class ProjectWorkFieldRepository : Repository<ProjectWorkField>, IProjectWorkFieldRepository
    {
        public ProjectWorkFieldRepository(DbContext context) : base(context)
        {
        }

        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public ProjectWorkField GetProjectWorkFieldsByWorkFieldAndProject(Guid projectId, Guid workFieldID)
        {
            return GetProjectWorkFieldsByWorkFieldWithProject(workFieldID).Where(m => m.Project.id == projectId).FirstOrDefault();
        }

        public List<ProjectWorkField> GetProjectWorkFieldsByWorkFieldWithProject(Guid workFieldID)
        {
            
            return HamkariContext.ProjectWorkFields.Include(m => m.Project).Include(m=> m.WorkField).Where<ProjectWorkField>(m => m.WorkField.id == workFieldID).ToList();
        }
    }
}
