using System.ComponentModel;

namespace Models.Models
{

    public class EducationRecord : BaseEntity
    {
        public EducationRecord()
        {
        }

       


        [DisplayName("مدرک تحصیلی")]
        public EducationDegree Degree { get; set; }

        [DisplayName("وضعیت")]
        public EducationState EducationState { get; set; }

        [DisplayName("نام موسسه آموزشی")]
        public string EducationInstitueName { get; set; }
        public Person? Person { get; set; }


    }
    public enum EducationState
    {
        Graduated, Studying
    }
    public enum EducationDegree
    {
        Bachelor, Master, phd
    }
}
