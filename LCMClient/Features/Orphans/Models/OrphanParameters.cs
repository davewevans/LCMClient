namespace LCMClient.Features.Orphans.Models
{
    public class OrphanParameters
    {
        public int PageSize { get; set; } = 20;

        public int PageNumber { get; set; } = 1;

        public string SearchQuery { get; set; }
    }
}
