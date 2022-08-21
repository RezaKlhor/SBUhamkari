using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ProjectDtos
{
    public record ProjectUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProjectExplain { get; set; }
        [Required]
        public ProjectState ProjectState { get; set; }
    }
}
