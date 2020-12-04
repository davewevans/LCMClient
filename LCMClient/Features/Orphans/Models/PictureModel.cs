using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Models
{
    public class PictureModel
    {
        public int PictureID { get; set; }

        public string PictureFileName { get; set; }

        public string BaseUrl { get; set; }

        public string Caption { get; set; }

        public DateTime CreatedAt { get; set; }

        public int OrphanID { get; set; }
    }
}
