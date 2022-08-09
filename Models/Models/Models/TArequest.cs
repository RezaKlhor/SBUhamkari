using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class TArequest : BaseEntity
    {
        public TArequest()
        {
        }

        public TArequest(string tittle, string text, Professor professor)
        {
            Tittle = tittle;
            Text = text;
            Professor = professor;
        }

        [DisplayName("عنوان درخواست")]
        [Required]
        public string Tittle { get; set; }

        [DisplayName("متن درخواست")]
        [Required]
        public string Text { get; set; }

        public Professor Professor { get; set; }
        public List<TAapplication>? TAapplications { get; set; }
    }
}
