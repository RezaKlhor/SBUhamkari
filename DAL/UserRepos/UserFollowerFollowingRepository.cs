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
            var f = HamkariContext.Followings.Include(m=> m.Follower).Where(m => m.FollowedID == id).ToList();
            return f;
            return Find(m => m.FollowedID == id).ToList();
        }

        public List<Following> GetFollowingsByFollowerID(Guid id)
        {
            var f = HamkariContext.Followings.Include(m=> m.Follower).Where(m => m.Follower.id == id).ToList();
            return f;
            return Find(m => m.Follower.id == id).ToList();
        }
    }
}
