using System;
using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Orphans.Models
{
    public class PictureCreationModel
    {
        public string PictureFileName { get; set; }

        public bool IsProfilePic { get; set; }

        [StringLength(256)]
        public string Caption { get; set; }

        public DateTime? TakenDate { get; set; }

        public string ContentType { get; set; }

        public int OrphanID { get; set; }
    }
}
