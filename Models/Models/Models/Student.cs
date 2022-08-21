using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Student : Person
    {
        public Student()
        {
        }

        

       

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره دانشجویی باید 8 رقم باشد")]
        [DisplayName("شماره دانشجویی")]
        public string StudentID { get; set; }

        public List<TAapplication>? TaApplications { get; set; }

    }
}
