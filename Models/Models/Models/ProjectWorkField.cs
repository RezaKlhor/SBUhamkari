using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProjectWorkField : BaseEntity
    {
        public Project Project { get; set; }
        public WorkField WorkField { get; set; }
    }
}
