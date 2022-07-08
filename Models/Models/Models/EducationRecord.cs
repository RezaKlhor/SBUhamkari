using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
   
    public class EducationRecord : BaseEntity
    {
        [DisplayName("مدرک تحصیلی")]
        public EducationDegree? Degree { get; set; }// degree?

        [DisplayName("وضعیت")]
        public EducationState EducationState { get; set; }
        public EducationInstitute? EducationInstitute { get; set; }
        public Person Person { get; set; }


    }
    public enum EducationState
    {
        Graduated,Studying
    }
    public enum EducationDegree
    {
        Bachelor, Master, phd
    }
}
