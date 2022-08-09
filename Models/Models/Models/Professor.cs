using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Professor : Person
    {
        public Professor()
        {
        }

        public Professor(uint personnelID, List<TArequest> tArequests)
        {
            PersonnelID = personnelID;
            TArequests = tArequests;
        }

        public Professor(uint personnelID)
        {
            PersonnelID = personnelID;
        }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "طول شماره پرسنلی باید 8 رقم باشد")]
        [DisplayName("شماره پرسنلی")]
        public uint PersonnelID { get; set; }
        public List<TArequest>? TArequests { get; set; }


    }
}
