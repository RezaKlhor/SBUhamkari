using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ContactInfo: BaseEntity
    {
        [DisplayName("عنوان راه ارتباطی")]
        [Required]
        public string Name { get; set; }

        [DisplayName("شماره تماس")]
        public string? ContactNumber { get; set; }

        [DisplayName("لینک ارتباط")]
        public string? ContactLink { get; set; }

        public User User { get; set; }

    }
}
