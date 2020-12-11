using LCMClient.Features.Shared.Models;
using System;
using System.Collections.Generic;

namespace LCMClient.Features.Sponsors.Models
{
    public class SponsorDetailsModel
    {
        public int SponsorID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName  => $"{FirstName} {LastName}";

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Email { get; set; }

        public string MainPhone { get; set; }

        public string Status { get; set; }

        public DateTime EntryDate { get; set; }

        public List<OrphanModel> Orphans { get; set; }

        public int OrphanCount => Orphans is not null ? Orphans.Count : 0;

        public DateTime? LastDonationDate { get; set; }
    }
}
