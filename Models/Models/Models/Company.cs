using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Company : User
    {
        public Company()
        {
        }

        public Company(string companyIDnumber, string companyName)
        {
            CompanyIDnumber = companyIDnumber;
            CompanyName = companyName;
        }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "طول شماره کسب شرکت باید ده رقم باشد")]
        [DisplayName("شماره کسب")]
        public string CompanyIDnumber { get; set; }


        [DisplayName("نام شرکت")]
        public string CompanyName { get; set; }





    }
}
