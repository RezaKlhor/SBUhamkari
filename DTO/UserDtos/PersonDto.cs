using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public class PersonDto : UserDto
    {
       

        public DateTime? BirthDate { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "طول نام بیشتر از حد مجاز میباشد")]
        
        public String Firstname { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "طول نام خانوادگی بیشتر از حد مجاز میباشد")]
       
        public String Lastname { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول کد ملی باید ده رقم باشد")]
       
        public string NationalIdNum { get; set; }

        [Required]
       
        public Gender gender { get; set; }

        
        public Byte[]? CV { get; set; }
    }
}
