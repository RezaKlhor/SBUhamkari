using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class PersonWorkField : BaseEntity
    {
        public  Person Person { get; set; }
        public WorkField WorkField { get; set; }
    }
}
