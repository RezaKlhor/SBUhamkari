namespace Models.Models
{
    public class ProjectParticapation : BaseEntity
    {
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
