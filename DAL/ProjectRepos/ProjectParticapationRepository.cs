using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.ProjectRepos
{
    public class ProjectParticapationRepository : Repository<ProjectParticapation>, IProjectParticapationRepository
    {
        public ProjectParticapationRepository(DbContext context) : base(context)
        {
        }

        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<ProjectParticapation> GetProjectParticapationsByUserWithProject(Guid userID)
        {
            return HamkariContext.ProjectParticapations.
                Where<ProjectParticapation>(m => m.User.id == userID).Include(m => m.Project).ToList();
        }
    }
}
