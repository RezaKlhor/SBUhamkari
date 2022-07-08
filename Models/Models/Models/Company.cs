using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Company: User
    {
        public Company()
        {
        }

        public Company(int companyID, string companyName)
        {
            CompanyID = companyID;
            CompanyName = companyName;
        }

        public Company(int companyID, string companyName, List<User>? companyMembers) : this(companyID, companyName)
        {
            CompanyMembers = companyMembers;
        }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول شماره کسب شرکت باید ده رقم باشد")]
        [DisplayName("شماره کسب")]
        public int CompanyID { get; set; }

        [Required]
        [DisplayName("نام شرکت")]
        public string CompanyName { get; set; }



        public List<User>? CompanyMembers { get; set; }

    }
}
