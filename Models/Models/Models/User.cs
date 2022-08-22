using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models.Models
{
    public enum Gender
    {
        male, female
    }
    public class User : BaseEntity
    {
        public User()
        {
            
        }

        public User(string username, string password, Faculty faculty)
        {
            Username = username;
            Password = password;
            Faculty = faculty;

        }

        public User(string username, string password, byte[]? avatar, Faculty faculty)
        {
            Username = username;
            Password = password;
            Avatar = avatar;
            Faculty = faculty;
        }

        [Required]
        [RegularExpression(@"([A-Za-z])+([A-Za-z]|(_)|(\.))*")]
        [DisplayName("نام کاربری")]
        public String Username { get; set; }


        [Required]
        [MinLength(8, ErrorMessage = "رمز عبور باید حداقل 8 رقم باشد")]
        [DisplayName("رمز عبور")]
        [JsonIgnore]
        public String Password { get; set; }

        [DisplayName("تصویر نمایه")]
        public Byte[]? Avatar { get; set; }

        public string? Bio { get; set; }

        public List<ContactInfo>? contactInfos { get; set; }
        public List<Notification>? notifications { get; set; }
        public List<News>? news { get; set; }




        public List<Feedback>? feedbacks { get; set; }
        public List<ProjectParticapation>? ProjectParticapations { get; set; }
        public List<SavedProject>? SavedProjects { get; set; }
        public Faculty? Faculty { get; set; }

        public List<Following> Following { get; set; }
        public Role Role { get; set; }
        public List<ParticipationInvitation> ParticipationInvitations { get; set; }




    }
}
