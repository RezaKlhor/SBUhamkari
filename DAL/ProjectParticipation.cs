

using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class ProjectParticipation : Repository<ProjectParticapation>, IProjectParticipation
    {
        public ProjectParticipation(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}