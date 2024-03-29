﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Feedback : BaseEntity
    {
        public Feedback()
        {
        }



        public Feedback(Score score, User user, Project project)
        {
            Score = score;
            User = user;
            Project = project;
        }

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
        onestar = 1, twostar = 2, threestar = 3, fourstar = 4, fivestar = 5
    }
}
