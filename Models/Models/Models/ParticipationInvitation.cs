using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ParticipationInvitation : BaseEntity
    {
        public InvitationState InvitationState { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public User InvitedUser { get; set; }

    }
    public enum InvitationState { Accepted,Declined}
}
