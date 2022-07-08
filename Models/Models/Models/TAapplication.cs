using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class TAapplication : BaseEntity
    {
        public string text { get; set; }
        public Byte[] Resume { get; set; }

        public Student Student { get; set; }

        public TArequest? Tarequest { get; set; }



    }
}
