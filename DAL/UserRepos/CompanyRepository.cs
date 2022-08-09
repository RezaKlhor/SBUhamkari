using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
