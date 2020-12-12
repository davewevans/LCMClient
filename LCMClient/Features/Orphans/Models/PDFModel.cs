using LCMClient.Features.Shared.Models;
using System;

namespace LCMClient.Features.Orphans.Models
{
    public class PDFModel
    {
        public int DocumentID { get; set; }

        public string FileName { get; set; }

        public string OriginalFileName { get; set; }

        public SponsorModel Sponsor { get; set; }

        public int OrphanID { get; set; }

        public int? SponsorID { get; set; }

        public bool AllSponsors { get; set; }

        public string BaseUrl { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
