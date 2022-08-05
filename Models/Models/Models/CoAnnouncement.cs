using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CoAnnouncement : BaseEntity
    {
        public CoAnnouncement()
        {
        }

        public CoAnnouncement(string tittle, string text, State state, ProjectManager creator, Project project)
        {
            Tittle = tittle;
            Text = text;
            State = state;
            Creator = creator;
            Project = project;
        }

        [DisplayName("عنوان درخواست همکاری")]
        [Required]
        public string Tittle { get; set; }

        [DisplayName("متن درخواست")]
        [Required]
        public string Text { get; set; }

        public State State { get; set; }

        public ProjectManager Creator { get; set; }
        
        public List<CoApplication>? CoApplications { get; set; }
    }
    public enum State
    {
        Open,Closed
    }
}
