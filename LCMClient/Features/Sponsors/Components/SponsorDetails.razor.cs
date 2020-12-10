using LCMClient.Features.Shared.Repository.Contracts;
using Microsoft.AspNetCore.Components;

namespace LCMClient.Features.Sponsors.Components
{
    public partial class SponsorDetails
    {
        [Inject]
        public ISponsorRepository sponsorRepository { get; set; }

        [Parameter]
        public int Id { get; set; }

    }
}
