using System;

namespace LCMClient.Features.Orphans.Models
{
    public class PictureModel
    {
        public int PictureID { get; set; }

        public string PictureFileName { get; set; }

        public string BaseUrl { get; set; }

        public string Caption { get; set; }

        public DateTime? TakenDate { get; set; }

        public DateTime EntryDate { get; set; }

        public int OrphanID { get; set; }
    }
}
