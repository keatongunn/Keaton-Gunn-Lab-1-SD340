using System.ComponentModel.DataAnnotations;

namespace Keaton_Gunn_Lab_1_SD340.Models
{
    public class Client
    {
        [Key]
        [Display(Name = "Client Identification Number")]
        public int Id { get; set; }

        [StringLength(25, ErrorMessage = "Sorry, First name must be 3-25 characters long", MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide a valid last name")]
        [Display(Name = "Last Name")]
        [StringLength(25, ErrorMessage = "Sorry, Last name must be 3-25 characters long")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}
