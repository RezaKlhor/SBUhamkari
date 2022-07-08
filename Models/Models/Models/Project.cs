using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Project : BaseEntity
    {

        [DisplayName("عنوان پژوهش")]
        [Required]
        public string Name { get; set; }

        [DisplayName("توضیحات پژوهش")]
        public string ProjectExplain { get; set; }

        [DisplayName("وضعیت پژوهش")]
        [Required]
        public ProjectState ProjectState { get; set; }

        public List<WorkField>? WorkFields { get; set; }
        public List<User> ProjectParticipants { get; set; }
        public List<Feedback>? Feedbacks { get; set; }
        public List<ProjectManager> ProjectManagers { get; set; }

        public List<ProjectFile>? Filess { get; set; }
        public List<Notification>? Notifications { get; set; }
        public List<CoAnnouncement>? CoAnnouncements { get; set; }
    }
    public enum ProjectState
    {
        Ongoing,Ended
    }
}
