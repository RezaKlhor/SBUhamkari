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

        public Notification(string notifTittle, string notifText, string senderName, string recieverName, User reciever, Project sender)
        {
            NotifTittle = notifTittle;
            NotifText = notifText;
            SenderName = senderName;
            RecieverName = recieverName;
            Reciever = reciever;
            Sender = sender;
        }

        [DisplayName("عنوان اعلان")]
        public string NotifTittle { get; set; }

        [DisplayName("متن اعلان")]
        public string NotifText { get; set; }

        public string SenderName { get; set; }

        public string RecieverName { get; set; }

        public User Reciever { get; set; }
        public Project Sender{ get; set; }
    }
}
