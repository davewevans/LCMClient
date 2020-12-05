namespace LCMClient.Features.Orphans.Models
{
    public class PictureCreationModel
    {
        public string PictureFileName { get; set; }

        public bool IsProfilePic { get; set; }

        public string Caption { get; set; }

        public string ContentType { get; set; }

        public int OrphanID { get; set; }
    }
}
