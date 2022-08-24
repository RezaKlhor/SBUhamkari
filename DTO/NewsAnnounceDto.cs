using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.ProjectDtos;

namespace DTO
{
    public record NewsAnnounceDto
    {
        public List<CoAnnouncementReadDto> News { get; set; }
        public List<AnnouncementReadDto> Announcements { get; set; }
    }
}
