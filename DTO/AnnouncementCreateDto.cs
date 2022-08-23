using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public record AnnouncementCreateDto
    {
        public string Tittle { get; set; }


        public string Text { get; set; }
        public Guid projectId { get; set; }
    }
}
