using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Person : User
    {
        public Person()
        {
        }

        

       

        [DisplayName("تاریخ تولد")]
        public DateTime? BirthDate { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "طول نام بیشتر از حد مجاز میباشد")]
        [DisplayName("نام")]
        public String Firstname { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "طول نام خانوادگی بیشتر از حد مجاز میباشد")]
        [DisplayName("نام خانوادگی")]
        public String Lastname { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول کد ملی باید ده رقم باشد")]
        [DisplayName("کد ملی")]
        public string NationalIdNum { get; set; }

        [Required]
        [DisplayName("جنسیت")]
        public Gender gender { get; set; }

        [DisplayName("رزومه")]
        public Byte[]? CV { get; set; }
        public List<Skill>? skills { get; set; }

        //[ForeignKey("WorkfieldID")]
        public List<PersonWorkField> PersonWorkFields { get; set; }

        public List<EducationRecord>? EducationRecords { get; set; }
        public List<CoApplication>? coApplications { get; set; }
    }
}
