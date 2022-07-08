using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class WorkField : BaseEntity
    {
        [DisplayName("عنوان زمینه کاری")]
        [Required]
        public string Name { get; set; }

        public User User { get; set; }

    }
}
