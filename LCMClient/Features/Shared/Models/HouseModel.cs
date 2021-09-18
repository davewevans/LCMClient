﻿using System;

namespace LCMClient.Features.Shared.Models
{
    public class GuardianModel
    {
        public int GuardianID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{ FirstName } { LastName }";

        // Used in auto-complete box
        public string NameAndLocation { get; set; }

        public DateTime EntryDate { get; set; }

        public string Location { get; set; } = string.Empty;
        
        public int NumberOfDependents { get; set; }
    }
}