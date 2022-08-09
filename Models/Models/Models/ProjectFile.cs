namespace Models.Models
{
    public class ProjectFile : BaseEntity
    {
        public ProjectFile()
        {

        }

        public ProjectFile(byte[] bytes, Project project)
        {
            this.bytes = bytes;
            Project = project;
        }
        public Byte[] bytes { get; set; }
        public Project Project { get; set; }
    }
}
