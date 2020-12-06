using System;

namespace LCMClient.Features.Dashboard.Models
{
    public class OrphanStatisticsModel 
    {
        public int ActiveCount { get; set; }

        public int InactiveCount { get; set; }

        public int ActiveInSchoolCount { get; set; }

        public int ActiveNotInSchoolCount { get; set; }

        public int InactiveMarriedCount { get; set; }

        public int InactiveWorkingCount { get; set; }

        public int InactiveDeceasedCount { get; set; }

        public int UnknownCount { get; set; }

        public int TotalCount { get; set; }

        public string ActiveCountText => $"{(ActiveCount / TotalCount) * 100 }%";

        public string InactiveCountText => $"{(InactiveCount / TotalCount) * 100 }%";

        public string ActiveInSchoolCountText => $"{(ActiveInSchoolCount / TotalCount) * 100 }%";

        public string ActiveNotInSchoolCountText => $"{(ActiveNotInSchoolCount / TotalCount) * 100 }%";

        public string InactiveMarriedCountText => $"{(InactiveMarriedCount / TotalCount) * 100 }%";

        public string InactiveWorkingCountText => $"{(InactiveWorkingCount / TotalCount) * 100 }%";

        public string InactiveDeceasedCountText => $"{(InactiveDeceasedCount / TotalCount) * 100 }%";

        public string UnknownCountText => $"{(UnknownCount / TotalCount) * 100 }%";
    } 
}