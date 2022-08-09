using System.ComponentModel;

namespace Models.Models
{
    public class ContactInfo : BaseEntity
    {
        public ContactInfo()
        {
        }

        public ContactInfo(string name, string? contactNumber, string? contactLink, User user, ContactInfoState entityState)
        {
            Name = name;
            ContactNumber = contactNumber;
            ContactLink = contactLink;
            User = user;
            EntityState = entityState;
        }

        [DisplayName("عنوان راه ارتباطی")]
        public string Name { get; set; }

        [DisplayName("شماره تماس")]
        public string? ContactNumber { get; set; }

        [DisplayName("لینک ارتباط")]
        public string? ContactLink { get; set; }

        public User User { get; set; }
        public ContactInfoState EntityState { get; set; }

    }
    public enum ContactInfoState { Public, Private }
}
