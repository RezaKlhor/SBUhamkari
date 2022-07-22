using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        public WorkField(string name, User user)
        {
            Name = name;
            User = user;
        }

        [DisplayName("عنوان زمینه کاری")]
        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        public List<Person>  People { get; set; }

    }
}
