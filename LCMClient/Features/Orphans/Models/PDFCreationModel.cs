namespace LCMClient.Features.Orphans.Models
{
    public class PDFCreationModel
    {
        public string FileName { get; set; }

        public string ContentType { get; set; }

        public int OrphanID { get; set; }

        public int? SponsorID { get; set; }

        public bool AllSponsors { get; set; }
    }
}
