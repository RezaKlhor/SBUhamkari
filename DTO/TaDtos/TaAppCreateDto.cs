using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TaDtos
{
    public record TaAppCreateDto : BaseDto
    {
        public int MyProperty { get; set; }
    }
}
