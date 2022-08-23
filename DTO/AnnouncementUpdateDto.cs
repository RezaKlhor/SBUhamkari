using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public record AnnouncementUpdateDto
    {
        public string Tittle { get; set; }

      
        public string Text { get; set; }
      
    }
}
