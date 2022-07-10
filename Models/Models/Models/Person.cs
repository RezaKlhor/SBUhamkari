using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Person : User
    {
        public Person()
        {
        }

        public Person(string username, string password, Faculty faculty,string firstname, string lastname, uint nationalIdNum, Gender gender):base( username,  password,  faculty)
        {
            Firstname = firstname;
            Lastname = lastname;
            NationalIdNum = nationalIdNum;
            this.gender = gender;
        }

        public Person(DateTime birthDate, string firstname, string lastname, uint nationalIdNum, Gender gender, byte[] cV)
        {
            BirthDate = birthDate;
            Firstname = firstname;
            Lastname = lastname;
            NationalIdNum = nationalIdNum;
            this.gender = gender;
            CV = cV;
        }

        [DisplayName("تاریخ تولد")]
        public DateTime BirthDate { get; set; }

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
        public uint NationalIdNum { get; set; }

        [Required]
        [DisplayName("جنسیت")]
        public Gender gender { get; set; }

        [DisplayName("رزومه")]
        public Byte[]? CV { get; set; }
        public List<Skill>? skills { get; set; }

       
        public List<EducationRecord>? EducationRecords { get; set; }
        public List<CoApplication>? coApplications { get; set; }
    }
}
