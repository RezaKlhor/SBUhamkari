using Microsoft.EntityFrameworkCore;
using Models;


namespace DAL
{
    public class UserFollowerFollowing : Repository<Following>,IUserFollowerFollowing
    {
        public UserFollowerFollowing(DbContext context) : base(context)
        {
        }

        public User User { get; set; }
        public List<User> Followers { get; set; }
        public List<User> Followings { get; set; }

        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
