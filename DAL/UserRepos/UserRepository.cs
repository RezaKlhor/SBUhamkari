global using Models.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class UserRepository : Repository<User>, IUserReopsitory
    {
        public UserRepository(DbContext context) : base(context)
        {
        }



        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public void AddUserInit()
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            return HamkariContext.Users.SingleOrDefault(m => m.Username == username);
        }
    }
}
