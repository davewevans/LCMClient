using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Admin.Models
{
    public class UserCreationModel
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,32}$", ErrorMessage = "Password must contain at least 6 characters, one digit, one uppercase letter, and one lowercase letter.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm the password.")]
        [Compare(nameof(Password), ErrorMessage = "Make sure both passwords are the same.")]
        public string ConfirmPassword { get; set; }

        public List<RoleModel> Roles { get; set; }
    }
}
