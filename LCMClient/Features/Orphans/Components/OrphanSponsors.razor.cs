using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
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

        protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

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
            DeleteConfirmationDialog.ShowDialog();
            sponsorToRemoveId = id;
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
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
                StateHasChanged();
            }
            sponsorToRemoveId = 0;
        }
    }
}
