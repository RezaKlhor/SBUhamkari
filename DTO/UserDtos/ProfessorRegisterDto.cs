using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record ProfessorRegisterDto : PersonRegisterDto
    {
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره پرسنلی باید 8 رقم باشد")]
        [DisplayName("شماره پرسنلی")]
        public string PersonnelID { get; set; }
    }
}
