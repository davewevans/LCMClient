﻿using System;

namespace LCMClient.Features.Shared.Narrations
{
    public class NarrationEditModel
    {
        public string Subject { get; set; }

        public string Note { get; set; }

        public DateTime EntryDate { get; set; }

        public int? OrphanID { get; set; }

        public int? GuardianID { get; set; }
    }
}