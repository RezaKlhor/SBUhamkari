using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{
    public record CompanyDto : UserDto
    {
       

        public uint CompanyIDnumber { get; set; }


        public string CompanyName { get; set; }


    }
}
