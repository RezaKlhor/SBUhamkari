using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ProjectDtos
{
    public record ProjectFileCreateDto 
    {
        public Byte[] File { get; set; }
        public Guid projectId { get; set; }
    }
}
