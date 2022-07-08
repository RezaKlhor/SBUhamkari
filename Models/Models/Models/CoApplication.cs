using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CoApplication: BaseEntity
    {
        [DisplayName("متن درخواست")]
        public string Text { get; set; }

        [DisplayName("رزومه")]
        [Required]
        public Byte[] CV { get; set; }
        public Person Applicant { get; set; }
        public CoAnnouncement? CoAnnouncement { get; set; }
    }
}
