using System.ComponentModel.DataAnnotations;

namespace DTO.UserDtos
{
    public class StudentRegisterDto : PersonRegisterDto
    {
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره دانشجویی باید 8 رقم باشد")]
        [System.ComponentModel.DisplayName("شماره دانشجویی")]
        public string StudentID { get; set; }
    }
}
