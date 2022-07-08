﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Professor : Person
    {

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره پرسنلی باید 8 رقم باشد")]
        [DisplayName("شماره پرسنلی")]
        public int PersonnelID { get; set; }
        public List<TArequest> TArequests { get; set; }


    }
}
