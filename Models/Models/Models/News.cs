using System.ComponentModel;

namespace Models.Models
{
    //add photos to news?
    public class News : BaseEntity
    {
        public News()
        {
        }

        public News(string tittle, string text, User user)
        {
            Tittle = tittle;
            Text = text;
            User = user;
        }

        [DisplayName("عنوان اطلاعیه")]
        public string Tittle { get; set; }


        [DisplayName("متن اطلاعیه")]
        public string Text { get; set; }


        public User User { get; set; }

    }
}
