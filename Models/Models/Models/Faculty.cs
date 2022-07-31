using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Faculty : BaseEntity
    {
        public Faculty()
        {

        }
        public Faculty(string name,EducationInstitute educationInstitute)
        {
            Name = name;
            educationInstitute = new EducationInstitute();
        }
        [DisplayName("نام دانشکده")]
        [Required]
        public string Name { get; set; }
        
        public List<User>? Users { get; set; }

    }
}
