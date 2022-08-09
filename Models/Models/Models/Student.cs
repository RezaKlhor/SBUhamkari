﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(uint studentID)
        {
            StudentID = studentID;
        }

        public Student(uint studentID, List<TAapplication>? taApplications) : this(studentID)
        {
            TaApplications = taApplications;
        }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره دانشجویی باید 8 رقم باشد")]
        [DisplayName("شماره دانشجویی")]
        public uint StudentID { get; set; }

        public List<TAapplication>? TaApplications { get; set; }

    }
}
