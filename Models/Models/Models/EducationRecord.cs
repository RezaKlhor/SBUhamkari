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
        public EducationRecord()
        {
        }

        public EducationRecord(EducationDegree? degree, EducationState educationState, EducationInstitute? educationInstitute, Person person)
        {
            Degree = degree;
            EducationState = educationState;
            EducationInstitute = educationInstitute;
            Person = person;
        }

        public EducationRecord(EducationState educationState, EducationInstitute educationInstitute, Person person)
        {
            EducationState = educationState;
            EducationInstitute = educationInstitute;
            Person = person;
        }

        [DisplayName("مدرک تحصیلی")]
        public EducationDegree? Degree { get; set; }// degree?

        [DisplayName("وضعیت")]
        public EducationState EducationState { get; set; }
        
        public EducationInstitute EducationInstitute { get; set; }
        public Person? Person { get; set; }


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
