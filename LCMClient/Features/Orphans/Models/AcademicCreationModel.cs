﻿using System;

namespace LCMClient.Features.Orphans.Models
{
    public class AcademicCreationModel
    {
        public string Grade { get; set; }
        public string KCPE { get; set; }
        public string KCSE { get; set; }
        public string School { get; set; }
        public DateTime EntryDate { get; set; }
        public int OrphanID { get; set; }
    }
}
