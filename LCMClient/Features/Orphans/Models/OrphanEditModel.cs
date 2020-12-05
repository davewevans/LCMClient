﻿using System;

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

        public string ProfileNumber { get; set; }

        public int? GuardianID { get; set; }
    }
}
