using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public record AnnouncementReadDto : BaseDto
    {
        public string Tittle { get; set; }
        public string Text { get; set; }
    }
}
