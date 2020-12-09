using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Guardians.Models
{
    public class GuardianCreationModel
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; }
    }
}
