namespace LCMClient.Features.Shared.Models
{
    public class PaginationModel
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
    }
}
