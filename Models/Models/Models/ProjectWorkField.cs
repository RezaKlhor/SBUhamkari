namespace Models.Models
{
    public class ProjectWorkField : BaseEntity
    {
        public Project Project { get; set; }
        public WorkField WorkField { get; set; }
    }
}
