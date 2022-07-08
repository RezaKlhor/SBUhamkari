

using System.ComponentModel;

namespace Models.Models
{
    public class EducationInstitute : BaseEntity
    {
        public EducationInstitute()
        {
        }

        public EducationInstitute(string name, List<EducationRecord>? educationRecords)
        {
            Name = name;
            EducationRecords = educationRecords;
        }

        [DisplayName("نام موسسه آموزشی")]
        public string Name { get; set; }
        public List<EducationRecord>? EducationRecords { get; set; }
        public List<Faculty>? Faculties { get; set; }

    }
}
