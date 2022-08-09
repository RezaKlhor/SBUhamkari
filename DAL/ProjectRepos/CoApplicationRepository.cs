using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.ProjectRepos
{
    public class CoApplicationRepository : Repository<CoApplication>, ICoApplicationRepository
    {
        public CoApplicationRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
