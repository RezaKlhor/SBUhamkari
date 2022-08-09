namespace Models.Models
{

    public class SavedProject : BaseEntity
    {
        public SavedProject()
        {
        }

        public SavedProject(User user, Project project)
        {
            User = user;
            Project = project;
        }

        public User User { get; set; }


        public Project Project { get; set; }

    }
}
