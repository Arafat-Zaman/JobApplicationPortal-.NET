using System.ComponentModel.DataAnnotations;

namespace JobApplicationPortal.Models
{
    public class JobApplication
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Position applied for is required")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Resume is required")]
        [DataType(DataType.Upload)]
        public IFormFile Resume { get; set; }
    }
}
