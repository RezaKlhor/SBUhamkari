﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.WorkFieldDto
{
    public class WorkFieldCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
