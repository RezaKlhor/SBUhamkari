using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public enum Gender
    {
        male,female
    }
    public class User: BaseEntity
    {
       

        [Required]
        [RegularExpression(@"({A-Za-z})+({A-Za-z}|(_)|(\.))*")]
        [DisplayName("نام کاربری")]
        public String Username { get; set; }


        [Required]
        [MinLength(8,ErrorMessage ="رمز عبور باید حداقل 8 رقم باشد")]
        [DisplayName("رمز عبور")]
        public String Password { get; set; }

        [DisplayName("تصویر نمایه")]
        public Byte[]? Avatar { get; set; }


        
        public List<ContactInfo>? contactInfos { get; set; }
        public List<Notification>? notifications { get; set; }
        public List<News>? news { get; set; }
        public List<WorkField>? workFields { get; set; }
        public List<User>? Following { get; set; }
        
        public List<Feedback>? feedbacks { get; set; }
        public List<Project>? projects { get; set; }
        public List<SavedProject>? SavedProjects { get; set; }
        public Faculty Faculty { get; set; }





    }
}
