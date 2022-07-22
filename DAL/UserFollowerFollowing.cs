using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class UserFollowerFollowing
    {
        public User User { get; set; }
        public List<User> Followers { get; set; }
        public List<User> Followings { get; set; }

    }
}
