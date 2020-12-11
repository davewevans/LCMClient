using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Narrations;
using System.Collections.Generic;

namespace LCMClient.Features.Guardians.Models
{
    public class GuardianDetailsModel
    {
        public int GuardianID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        public string Location { get; set; } = string.Empty;

        public int OrphanCount => Orphans is not null ? Orphans.Count : 0;

        public int NarrationsCount => Narrations is not null ? Narrations.Count : 0;

        public List<OrphanModel> Orphans { get; set; }

        public List<NarrationModel> Narrations { get; set; }
    }
}
