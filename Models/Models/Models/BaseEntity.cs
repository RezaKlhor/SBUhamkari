using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            id = System.Guid.NewGuid();
            CreateTime = DateTime.Now;
        }
        [Key]
        public System.Guid id { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        
        public DateTime? DeleteTime { get; set; }
        
    }
}
