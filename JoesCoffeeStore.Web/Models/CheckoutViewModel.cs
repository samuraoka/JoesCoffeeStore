using System;
using System.ComponentModel.DataAnnotations;

namespace JoesCoffeeStore.Web.Models
{
    public class CheckoutViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Blog { get; set; }

        public string Remark { get; set; }

        [Display(Name = "Requested delivery date")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Wrapping paper color")]
        public string Color { get; set; }

        [Display(Name = "How many bows on the package?")]
        public string Bow { get; set; }
    }
}
