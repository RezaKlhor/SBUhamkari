using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDtos
{

    public record ProfessorDto : PersonDto
    {
       

        public uint PersonnelID { get; set; }
    }
}
