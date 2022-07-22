using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Following: BaseEntity
    {


        
        public User Follower { get; set; }

        
        public Guid FollowedID { get; set; }
    }
}
