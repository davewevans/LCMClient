using System;
using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Orphans.Models
{
    public class OrphanCreationModel
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Gender { get; set; }     

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string LCMStatus { get; set; }

        [Required]
        public string ProfileNumber { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime? YearOfAdmission { get; set; }

        [Required]
        public string Condition { get; set; }
    }
}
