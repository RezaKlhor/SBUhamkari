using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record UserStatisticsDto
    {
        public string TotalFollowers { get; set; }
        public string TotalFollowings { get; set; }
        public string TotalProjects { get; set; }
    }
}
