using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
