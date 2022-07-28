using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProjectParticapation : BaseEntity
    {
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
