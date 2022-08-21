using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class ProjectWorkField : BaseEntity
    {
        [ForeignKey("projectRelatedforeignKey")]
        public Project Project { get; set; }
        public WorkField WorkField { get; set; }
    }
}
