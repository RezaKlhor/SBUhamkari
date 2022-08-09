namespace Models.Models
{
    public class ProjectManager : BaseEntity
    {
        public ProjectManager()
        {
        }

        public ProjectManager(Project project, User user)
        {
            Project = project;
            User = user;
        }

        public Project Project { get; set; }
        public User User { get; set; }
        public List<CoAnnouncement>? CoAnnouncements { get; set; }
        public List<ParticipationInvitation>? ParticipationInvitations { get; set; }
    }
}
