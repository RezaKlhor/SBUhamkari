using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class TArequest : BaseEntity
    {
        [DisplayName("عنوان درخواست")]
        [Required]
        public string Tittle { get; set; }

        [DisplayName("متن درخواست")]
        [Required]
        public string Text { get; set; }

        public Professor Professor { get; set; }

    }
}
