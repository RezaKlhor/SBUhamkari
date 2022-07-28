global using Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Models;

namespace DAL.UserRepos
{
    public class UserRepository : Repository<User>, IUserReopsitory
    {
        public UserRepository(DbContext context) : base(context)
        {
        }



        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
