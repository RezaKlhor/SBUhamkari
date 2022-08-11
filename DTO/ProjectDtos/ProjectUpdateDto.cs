using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ProjectDtos
{
    public class ProjectUpdateDto
    {
        public string Name { get; set; }
        public string ProjectExplain { get; set; }
        public ProjectState ProjectState { get; set; }
    }
}
