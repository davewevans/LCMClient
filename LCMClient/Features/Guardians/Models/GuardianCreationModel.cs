using System.Collections.Generic;
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
        
        public string MainPhone { get; set; }
        
        public string AltPhone1 { get; set; }

        public string AltPhone2 { get; set; }

        public string AltPhone3 { get; set; }
    }
}
