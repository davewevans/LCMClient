using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LCMClient.Annotations;

namespace LCMClient.Features.Orphans.Models
{
    public class OrphanEditModel 
    {
        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string LCMStatus { get; set; }

        public string ExitStatus { get; set; }

        public string ProfileNumber { get; set; }

        public string Location { get; set; }

        public string RelationshipToGuardian { get; set; }

        public int? GuardianID { get; set; }

        public DateTime? YearOfAdmission { get; set; }

        public string Condition { get; set; }


    }
}
