using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Models
{
    public class NarrationModel
    {
        public int NarrationID { get; set; }

        public string Subject { get; set; }

        public string Note { get; set; }

        public DateTime EntryDate { get; set; }

        public int? OrphanID { get; set; }

        public int? GuardianID { get; set; }
    }
}
