﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CompanyRegisterDto : UserRegisterDto
    {
        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول شماره کسب شرکت باید ده رقم باشد")]
        [DisplayName("شماره کسب")]
        public uint CompanyIDnumber { get; set; }


        [DisplayName("نام شرکت")]
        public string CompanyName { get; set; }
    }
}