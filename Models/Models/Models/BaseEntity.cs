using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class BaseEntity
    {
        [Key]
        public System.Guid guid { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        
        public DateTime? DeleteTime { get; set; }
        
    }
}
