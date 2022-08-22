using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record ContactInfoCreateDto
    {
        public string Name { get; set; }

       
        public string? ContactNumber { get; set; }

      
        public string? ContactLink { get; set; }

     
        public ContactInfoState EntityState { get; set; }
    }
}
