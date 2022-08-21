using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public record BaseDto
    {

        [Key]
        public System.Guid id { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }


        public DateTime? DeleteTime { get; set; }


    }

}
