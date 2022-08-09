

using System.ComponentModel;

namespace Models.Models
{
    public class EducationInstitute : BaseEntity
    {
        public EducationInstitute()
        {
        }

        public EducationInstitute(string name)
        {
            Name = name;
        }

        [DisplayName("نام موسسه آموزشی")]
        public string Name { get; set; }
        public List<EducationRecord>? EducationRecords { get; set; }


    }
}
