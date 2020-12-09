using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Sponsors.Models
{
    public class SponsorCreationModel
    {
        [StringLength(128)]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(128)]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; } = string.Empty;

        [StringLength(128)]
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "Postal code is required.")]
        public string ZipCode { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [StringLength(128)]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string MainPhone { get; set; }
    }
}
