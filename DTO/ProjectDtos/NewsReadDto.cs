using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ProjectDtos
{
    public record CoAnnouncementReadDto : BaseDto
    {
        [Required]
        public string Tittle { get; set; }

        [Required]
        public string Text { get; set; }


       
    }
}
