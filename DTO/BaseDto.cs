using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class BaseDto
    {

        [Key]
        public System.Guid id { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }


        public DateTime? DeleteTime { get; set; }


    }

}
