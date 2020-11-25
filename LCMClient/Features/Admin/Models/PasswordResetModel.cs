using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Admin.Models
{
    public class PasswordResetModel
    {
        [Required(ErrorMessage = "Please enter a password.")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,32}$", ErrorMessage = "Password must contain at least 6 characters, one digit, one uppercase letter, and one lowercase letter.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please confirm the password.")]
        [Compare(nameof(NewPassword), ErrorMessage = "Make sure both passwords are the same.")]
        public string ConfirmPassword { get; set; }
    }
}
