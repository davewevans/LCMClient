using System.ComponentModel.DataAnnotations;

namespace LCMClient.Auth
{
    public class UserEdit
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }    

        [Required]
        public string Role { get; set; }
    }
}
