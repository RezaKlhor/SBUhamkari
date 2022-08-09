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

        public List<ProjectWorkField> GetProjectWorkFieldsByWorkFieldWithProject(Guid workFieldID)
        {
            return HamkariContext.ProjectWorkFields.Include(m => m.Project).Where<ProjectWorkField>(m => m.WorkField.id == workFieldID).ToList();
        }
    }
}
