using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record SkillCreateDto
    {
        public string SkillTitle { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public Guid PersonId { get; set; }
    }
}
