using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public class PersonRegisterDto : UserRegisterDto
    {
        [Required]
        [StringLength(20, ErrorMessage = "طول نام بیشتر از حد مجاز میباشد")]
        [DisplayName("نام")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "طول نام خانوادگی بیشتر از حد مجاز میباشد")]
        [DisplayName("نام خانوادگی")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول کد ملی باید ده رقم باشد")]
        [DisplayName("کد ملی")]
        public string NationalIdNum { get; set; }

        [Required]
        [DisplayName("جنسیت")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender gender { get; set; }
    }
}
