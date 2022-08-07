using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    
    public class SavedProject : BaseEntity
    {
        public SavedProject()
        {
        }

        public SavedProject(User user, Project project)
        {
            User = user;
            Project = project;
        }

        public User User { get; set; }

        
        public Project Project { get; set; }

    }
}
