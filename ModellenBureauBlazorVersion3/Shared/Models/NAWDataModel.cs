using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class NAWDataModel
    {
        [Key]
        public string id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Street name")]
        public string StreetName { get; set; }
        [Display(Name = "Street number")]
        public string StreetNumber { get; set; }
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }
        public string City { get; set; }
        [EmailAddress]
        [Display(Name = "Email adress")]
        public string EmailAdress { get; set; }
        [Display(Name = "Telephone number")]
        public string TelephoneNumber { get; set; }
        public string Age { get; set; }

    }
}
