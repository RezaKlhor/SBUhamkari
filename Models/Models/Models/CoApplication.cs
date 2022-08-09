using System.ComponentModel;

namespace Models.Models
{
    public class CoApplication : BaseEntity
    {
        public CoApplication()
        {
        }

        public CoApplication(string text, byte[] cV, Person applicant, CoAnnouncement coAnnouncement)
        {
            Text = text;
            CV = cV;
            Applicant = applicant;
            CoAnnouncement = coAnnouncement;
        }

        [DisplayName("متن درخواست")]
        public string Text { get; set; }

        [DisplayName("رزومه")]
        public Byte[] CV { get; set; }

        public Person? Applicant { get; set; }
        public CoAnnouncement CoAnnouncement { get; set; }
    }
}
