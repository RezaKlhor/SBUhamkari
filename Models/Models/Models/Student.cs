using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Student: Person
    {
        public Student()
        {
        }

        public Student(int studentID)
        {
            StudentID = studentID;
        }

        public Student(int studentID, List<TAapplication>? taApplications) : this(studentID)
        {
            TaApplications = taApplications;
        }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره دانشجویی باید 8 رقم باشد")]
        [DisplayName("شماره دانشجویی")]
        public int StudentID { get; set; }

        public List<TAapplication>? TaApplications { get; set; }

    }
}
