using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProjectDto : BaseDto
    {

        [DisplayName("عنوان پژوهش")]
        [Required]
        public string Name { get; set; }

        [DisplayName("توضیحات پژوهش")]
        public string ProjectExplain { get; set; }

        [DisplayName("وضعیت پژوهش")]
        [Required]
        public ProjectState ProjectState { get; set; }


    }
}
