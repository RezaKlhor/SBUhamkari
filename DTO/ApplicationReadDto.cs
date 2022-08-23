﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public record ApplicationReadDto
    {
        public string Text { get; set; }


        public Byte[]? CV { get; set; }

        public Guid UserId { get; set; }
    }
}
