using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //[ForeignKey("WorkfieldID")]
        public List<ProjectWorkField>? ProjectWorkFields { get; set; }
        public List<ProjectParticapation>? ProjectParticipants { get; set; }
        public List<Feedback>? Feedbacks { get; set; }
        public List<ProjectManager> ProjectManagers { get; set; }

        public List<ProjectFile>? Filess { get; set; }
        public List<Notification>? Notifications { get; set; }

        public List<ProjectNews>? ProjectNews { get; set; }
    }
    public enum ProjectState
    {
        
        Ongoing, Ended
    }
}
