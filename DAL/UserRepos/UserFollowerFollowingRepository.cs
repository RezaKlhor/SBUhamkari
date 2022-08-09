using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class UserFollowerFollowingRepository : Repository<Following>, IUserFollowerFollowingRepository
    {
        public UserFollowerFollowingRepository(DbContext context) : base(context)
        {
        }

       

        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<Following> GetFollowingsByFollowedID(Guid id)
        {
            return Find(m => m.FollowedID == id).ToList();
        }

        public List<Following> GetFollowingsByFollowerID(Guid id)
        {
            return Find(m => m.Follower.id == id).ToList();
        }
    }
}
