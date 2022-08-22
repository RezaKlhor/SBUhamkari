namespace Models.Models
{
    public class ParticipationInvitation : BaseEntity
    {
        public ParticipationInvitation()
        {
        }

        public ParticipationInvitation(InvitationState invitationState, ProjectManager projectManager, User invitedUser)
        {
            InvitationState = invitationState;
            ProjectManager = projectManager;
            InvitedUser = invitedUser;
        }

        public InvitationState InvitationState { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public User InvitedUser { get; set; }

    }
    public enum InvitationState { Accepted, Declined,Pending }
}
