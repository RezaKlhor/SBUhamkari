using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record SkillReadDto: BaseDto
    {
        public string SkillTitle { get; set; }
        public SkillLevel SkillLevel { get; set; }
    }
}
