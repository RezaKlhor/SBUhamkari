using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models.Models
{
    public class WorkField : BaseEntity
    {
        public WorkField()
        {

        }

        public WorkField(string name, List<Person> people)
        {
            Name = name;
            People = people;
        }

        [DisplayName("عنوان زمینه کاری")]
        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        [ForeignKey("PersonID")]
        public List<PersonWorkField>? PersonWorkFields   { get; set; }

        [ForeignKey("ProjectID")]
        public List<ProjectWorkFields>? ProjectWorkFields { get; set; }
    }
}
