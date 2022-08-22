using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class PersonWorkField : BaseEntity
    {
        [ForeignKey("PersonRelatedforeignKey")]
        public Person Person { get; set; }
        public WorkField WorkField { get; set; }
    }
}
