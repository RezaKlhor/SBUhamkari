using System.ComponentModel;

namespace Models.Models
{
    public class CoAnnouncement : BaseEntity
    {
        public CoAnnouncement()
        {
        }

        public CoAnnouncement(string tittle, string text, State state, ProjectManager creator)
        {
            Tittle = tittle;
            Text = text;
            State = state;
            Creator = creator;
        }

        [DisplayName("عنوان درخواست همکاری")]
        public string Tittle { get; set; }

        [DisplayName("متن درخواست")]
        public string Text { get; set; }

        public State State { get; set; }

        public ProjectManager Creator { get; set; }

        public List<CoApplication>? CoApplications { get; set; }
    }
    public enum State
    {
        Open, Closed
    }
}
