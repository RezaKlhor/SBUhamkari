using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    //add photos to news?
    public class News : BaseEntity
    {
        [DisplayName("عنوان اطلاعیه")]
        [Required]
        public string Tittle { get; set; }

        [Required]
        [DisplayName("متن اطلاعیه")]
        public string Text { get; set; }


        public User User { get; set; }

    }
}
