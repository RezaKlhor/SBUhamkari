﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TaDtos
{
    public record TaRequestReadDto :BaseDto
    {
        public Guid id { get; set; }

        [Required(ErrorMessage ="عنوان درخواست خالی است")]
        public string Tittle { get; set; }

        
        [Required(ErrorMessage ="توضیحات درخواست اجباری است")]
        public string Text { get; set; }

        [Required]
        public Guid ProfessorId { get; set; }



    }
}
