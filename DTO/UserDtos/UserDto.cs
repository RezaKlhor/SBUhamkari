using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record UserDto : BaseDto
    {
        public UserDto()
        {
        }



        public string Bio { get; set; }
        public string Role { get; set; }
        public String Username { get; set; }
        public string? Avatar { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public Gender gender { get; set; }
        public string PersonnelID { get; set; }
        public string StudentID { get; set; }
        public string Faculty { get; set; }
        public string NationalIdNum { get; set; }
        public string? CV { get; set; }

        public string CompanyIDnumber { get; set; }
        public string CompanyName { get; set; }
        public DateTime? BirthDate { get; set; }

        


    }
}
