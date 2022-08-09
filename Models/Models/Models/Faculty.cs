using System.ComponentModel;

namespace Models.Models
{
    public class Faculty : BaseEntity
    {
        public Faculty()
        {

        }
        public Faculty(string name)
        {
            Name = name;

        }
        [DisplayName("نام دانشکده")]
        public string Name { get; set; }

        public List<User>? Users { get; set; }

    }
}
