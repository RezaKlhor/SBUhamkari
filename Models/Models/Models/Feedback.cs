﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Feedback : BaseEntity
    {
        [DisplayName("متن نظر")]
        public string? Text { get; set; }

        [DisplayName("امتیاز")]
        [Required]
        public Score Score { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Project Project { get; set; }



    }
    public enum Score
    {
        onestar=1,twostar=2,threestar=3,fourstar=4,fivestar=5
    }
}
