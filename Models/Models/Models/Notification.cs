using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Notification : BaseEntity
    {
        public Notification()
        {
        }

        public Notification(string notifTittle, string notifText, User reciever, Project sender)
        {
            NotifTittle = notifTittle;
            NotifText = notifText;
            Reciever = reciever;
            Sender = sender;
        }

        [DisplayName("عنوان اعلان")]
        [Required]
        public string NotifTittle { get; set; }

        [DisplayName("متن اعلان")]
        [Required]
        public string NotifText { get; set; }


        public User Reciever { get; set; }
        public Project Sender{ get; set; }
    }
}
