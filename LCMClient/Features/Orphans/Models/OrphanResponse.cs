using System.Collections.Generic;

namespace LCMClient.Features.Orphans.Models
{
    public class OrphanResponse
    {
        public List<OrphanModel> Orphans { get; set; }

        // public ResponseMetaData MetaData { get; set; }
    }
}
