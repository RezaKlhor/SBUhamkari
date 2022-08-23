using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ProjectDtos
{
    public record FeedbackCreateDto
    {
        public string? Text { get; set; }

        
        [Required]
        public Score Score { get; set; }

       

        [Required]
        public Guid ProjectId { get; set; }

    }
}
