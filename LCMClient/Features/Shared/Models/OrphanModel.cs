using System;

namespace LCMClient.Features.Shared.Models
{
    public class OrphanModel
    {
        public int OrphanID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string LCMStatus { get; set; }

        public string Location { get; set; }

        public string ProfileNumber { get; set; }

        public string RelationshipToGuardian { get; set; }

        public int? GuardianID { get; set; }

        public string ProfilePicFileName { get; set; }

        public string ProfilePicUrl { get; set; }

        public DateTime? YearOfAdmission { get; set; }

        public string Condition { get; set; }

        public override string ToString()
        {
            return $"{ FirstName } { MiddleName } { LastName } { Gender } { DateOfBirth:d} { LCMStatus } { ProfileNumber }";
        }
    }
}
