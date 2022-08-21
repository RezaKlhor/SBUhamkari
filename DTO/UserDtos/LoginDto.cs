using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record LoginDto
    {
        [Required]
        [RegularExpression(@"([A-Za-z])+([A-Za-z]|(_)|(\.))*")]
        [DisplayName("نام کاربری")]
        public string Username { get; set; }


        [Required]
        [MinLength(8, ErrorMessage = "رمز عبور باید حداقل 8 رقم باشد")]
        [DisplayName("رمز عبور")]
        public string Password { get; set; }

    }
}
