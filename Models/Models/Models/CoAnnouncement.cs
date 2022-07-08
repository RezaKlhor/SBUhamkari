using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CoAnnouncement : BaseEntity
    {
        [DisplayName("عنوان درخواست همکاری")]
        [Required]
        public string Tittle { get; set; }

        [DisplayName("متن درخواست")]
        [Required]
        public string Text { get; set; }

        public State State { get; set; }

        public User Creator { get; set; }
        public Project Project { get; set; }
    }
    public enum State
    {
        Open,Closed
    }
}
