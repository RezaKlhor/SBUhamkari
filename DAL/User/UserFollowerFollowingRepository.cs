using Microsoft.EntityFrameworkCore;
using Models;


namespace DAL.User
{
    public class UserFollowerFollowingRepository : Repository<Following>, IUserFollowerFollowingRepository
    {
        public UserFollowerFollowingRepository(DbContext context) : base(context)
        {
        }

       

        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
