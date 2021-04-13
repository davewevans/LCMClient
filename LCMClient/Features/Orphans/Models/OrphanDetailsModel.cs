﻿using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Narrations;
using System;
using System.Collections.Generic;

namespace LCMClient.Features.Orphans.Models
{
    public class OrphanDetailsModel
    {
        public int OrphanID { get; set; }

        public string FirstName { get; set; } = string.Empty;
  
        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string LCMStatus { get; set; }
        
        public string ExitStatus { get; set; }
      
        public string ProfileNumber { get; set; }

        public string Location { get; set; }

        public DateTime EntryDate { get; set; }

        public string RelationshipToGuardian { get; set; }

        public int? GuardianID { get; set; }

        public string ProfilePicFileName { get; set; }

        public string ProfilePicUrl { get; set; }

        public DateTime? YearOfAdmission { get; set; }

        public string Condition { get; set; }

        public List<PictureModel> Pictures { get; set; }

        public List<PDFModel> PDFs { get; set; }

        public List<SponsorModel> Sponsors { get; set; }

        public GuardianModel Guardian { get; set; }

        public List<NarrationModel> Narrations { get; set; }

        public List<AcademicModel> Academics { get; set; }
    }
}
