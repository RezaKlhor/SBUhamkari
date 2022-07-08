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


        [ForeignKey("UserID")]
        public Guid UserID { get; set; }

        [ForeignKey("FollowedID")]
        public Guid FollowedID { get; set; }
    }
}
