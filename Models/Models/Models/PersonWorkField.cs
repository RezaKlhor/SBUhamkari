namespace Models.Models
{
    public class PersonWorkField : BaseEntity
    {
        public Person Person { get; set; }
        public WorkField WorkField { get; set; }
    }
}
