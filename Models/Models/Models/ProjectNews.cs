using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    //add photos to news?
    public class ProjectNews : BaseEntity
    {
        public ProjectNews()
        {
        }



        [DisplayName("عنوان اطلاعیه")]
        [Required]
        public string Tittle { get; set; }

        [Required]
        [DisplayName("متن اطلاعیه")]
        public string Text { get; set; }


        public Project Project { get; set; }

    }
}
