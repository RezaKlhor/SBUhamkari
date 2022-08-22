using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record NotificationDto : BaseDto
    {
        public string NotifTittle { get; set; }

        
        public string NotifText { get; set; }

        public string SenderName { get; set; }

        public string RecieverName { get; set; }

        public Guid RecieverId { get; set; }
        public Guid ProjectSenderId { get; set; }
    }
}
