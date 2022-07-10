using Microsoft.EntityFrameworkCore;
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

        public Company(uint companyID, string companyName)
        {
            CompanyIDnumber = companyID;
            CompanyName = companyName;
        }

        public Company(uint companyID, string companyName, List<User>? companyMembers) : this(companyID, companyName)
        {
            CompanyMembers = companyMembers;
        }
        

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول شماره کسب شرکت باید ده رقم باشد")]
        [DisplayName("شماره کسب")]
        public uint CompanyIDnumber { get; set; }

        [Required]
        [DisplayName("نام شرکت")]
        public string CompanyName { get; set; }



        public List<User>? CompanyMembers { get; set; }

    }
}
