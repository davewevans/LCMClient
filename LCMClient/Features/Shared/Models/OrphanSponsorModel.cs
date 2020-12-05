using LCMClient.Features.Orphans.Models;
using System;

namespace LCMClient.Features.Shared.Models
{
    public class OrphanSponsorModel
    {
        public int OrphanID { get; set; }
        public int SponsorID { get; set; }
        public OrphanModel Orphan { get; set; }
        public SponsorModel Sponsor { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
