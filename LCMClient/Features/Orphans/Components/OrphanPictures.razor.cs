using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanPictures
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject] public IOrphanRepository OrphanRepository { get; set; }

        private async Task HandlePostUpload(OrphanDetailsModel orphan)
        {
            Orphan.Pictures = await OrphanRepository.GetOrphanPicturesAsync(Orphan.OrphanID);
            StateHasChanged();
        }
    }
}
