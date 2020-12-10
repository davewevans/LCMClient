using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Features.Shared;
using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanSponsors
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Parameter]
        public EventCallback HandleOrphanEdited { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepository { get; set; }

        [Inject]
        public IOrphanSponsorRepository OrphanSponsorRepository { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        private bool showDelConfirmDialog = false;

        private ViewMode viewMode = ViewMode.List;

        private int sponsorToRemoveId = 0;

        private void OnAddClick()
        {
            viewMode = ViewMode.AddNew;
        }

        public async Task OnAddNewComplete(bool recordAdded)
        {
            viewMode = ViewMode.List;
            if (recordAdded)
            {
                Orphan.Sponsors = await OrphanRepository.GetOrphanSponsorsAsync(Orphan.OrphanID);
                await HandleOrphanEdited.InvokeAsync("");
                StateHasChanged();
            }
        }
        private void OnRemoveClick(int id)
        {            
            sponsorToRemoveId = id;
            showDelConfirmDialog = true;
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed)
            {
                if (Orphan == null || sponsorToRemoveId == 0) return;
                var recordToRemove = new OrphanSponsorModel
                {
                    OrphanID = Orphan.OrphanID,
                    SponsorID = sponsorToRemoveId
                };
                await OrphanSponsorRepository.RemoveAssignment(recordToRemove);
                Orphan.Sponsors = await OrphanRepository.GetOrphanSponsorsAsync(Orphan.OrphanID);
                await HandleOrphanEdited.InvokeAsync("");
                Toaster.Add("Record deleted.", MatToastType.Success);
                StateHasChanged();
            }
            sponsorToRemoveId = 0;
        }
    }
}
