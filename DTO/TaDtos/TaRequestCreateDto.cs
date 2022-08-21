using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TaDtos
{
    public record TaRequestCreateDto
    {
        
        [Required(ErrorMessage ="عنوان درخواست خالی است")]
        public string Tittle { get; set; }

        
        [Required(ErrorMessage ="توضیحات درخواست اجباری است")]
        public string Text { get; set; }


    }
}
