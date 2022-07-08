﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProjectManager : BaseEntity
    {
        public ProjectManager()
        {
        }

        public ProjectManager(Project project, User user)
        {
            Project = project;
            User = user;
        }

        public Project Project { get; set; }
        public User User { get; set; }
        public List<CoAnnouncement>? CoAnnouncements { get; set; }
    }
}
