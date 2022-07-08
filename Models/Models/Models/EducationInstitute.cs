

using System.ComponentModel;

namespace Models.Models
{
    public class EducationInstitute : BaseEntity
    {
        [DisplayName("نام موسسه آموزشی")]
        public string Name { get; set; }
        public List<EducationRecord> EducationRecords { get; set; }
       
    }
}
