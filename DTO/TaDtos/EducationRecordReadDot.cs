using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TaDtos
{
    public record EducationRecordReadDot : BaseDto
    {
        public EducationDegree Degree { get; set; }

        public EducationState EducationState { get; set; }

        public string EducationInstituteName { get; set; }
    }
}
