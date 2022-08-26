using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models.Models
{
    public class WorkField : BaseEntity
    {
        public WorkField()
        {

        }



        [DisplayName("عنوان زمینه کاری")]
        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        public List<PersonWorkField>? PersonWorkFields { get; set; }

        [ForeignKey("ProjectID")]
        public List<ProjectWorkField>? ProjectWorkFields { get; set; }
    }
}
