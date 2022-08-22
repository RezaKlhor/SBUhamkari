using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TaDtos
{
    public record TaAppCreateDto 
    {
        public string? text { get; set; }
        public Byte[] Resume { get; set; }

       

        public Guid TarequestId { get; set; }
    }
}
