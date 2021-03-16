using System;

namespace LCMClient.Features.Shared.Narrations
{
    public class NarrationEditModel
    {
        public string Subject { get; set; }
        
        public string SubjectPendingApproval { get; set; }
        public string Note { get; set; }
        
        public string NotePendingApproval { get; set; }
        public DateTime EntryDate { get; set; }
        
        public bool Approved { get; set; }

        public DateTime? SubmittedAt { get; set; }

        public string SubmittedByID { get; set; }

        public DateTime? ApprovedAt { get; set; }

        public string ApprovedByID { get; set; }

        public int? OrphanID { get; set; }

        public int? GuardianID { get; set; }
    }
}
