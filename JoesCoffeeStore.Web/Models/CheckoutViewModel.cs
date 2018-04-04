using System;
using System.ComponentModel.DataAnnotations;

namespace JoesCoffeeStore.Web.Models
{
    public class CheckoutViewModel
    {
        [Display(Name = "First Name")]
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Number { get; set; }

        [Display(Name = "Zip code")]
        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string City { get; set; }

        [RegularExpression("[A-Za-z]{3}")]
        [Required]
        public string Country { get; set; }

        [Display(Name = "Phone number")]
        [Required]
        public string PhoneNumber { get; set; }

        public string Blog { get; set; }

        public string Remark { get; set; }

        [Display(Name = "Requested delivery date")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Wrapping paper color")]
        public string Color { get; set; }

        [Display(Name = "How many bows on the package?")]
        [Range(minimum: 1, maximum: 10)]
        public int Bow { get; set; }
    }
}
