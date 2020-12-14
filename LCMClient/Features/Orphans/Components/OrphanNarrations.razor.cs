using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Shared;
using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Narrations;
using LCMClient.Features.Shared.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanNarrations
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject]
        public INarrationRepository NarrationRepository { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        private bool showDelConfirmDialog = false;

        private ViewMode viewMode = ViewMode.List;

        private int narrationIdToDelete = 0;

        private NarrationEditModel narrationEdit;

        private int narrationIdToEdit = 0;

        private int counter = 0;

        private void OnAddClick()
        {
            viewMode = ViewMode.AddNew;
        }

        public async Task OnAddNewComplete(bool recordAdded)
        {
            viewMode = ViewMode.List;
            if (recordAdded)
            {
                Orphan.Narrations = await NarrationRepository.GetOrphanNarrations(Orphan.OrphanID);
                StateHasChanged();
            }
        }

        private void OnEditClick(NarrationModel narrationRecord)
        {
            narrationEdit = new NarrationEditModel
            {
                Subject = narrationRecord.Subject,
                Note = narrationRecord.Note,
                OrphanID = narrationRecord.OrphanID,
                EntryDate = narrationRecord.EntryDate
            };
            narrationIdToEdit = narrationRecord.NarrationID;
            viewMode = ViewMode.Edit;
        }

        private async Task OnEditComplete(bool recordEdited)
        {
            showDelConfirmDialog = false;
            narrationIdToEdit = 0;
            viewMode = ViewMode.List;
            Orphan.Narrations = await NarrationRepository.GetOrphanNarrations(Orphan.OrphanID);
            StateHasChanged();
        }

        private void OnDeleteClick(int narrationId)
        {
            showDelConfirmDialog = false;
            narrationIdToDelete = narrationId;
            showDelConfirmDialog = true;
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            viewMode = ViewMode.List;
            showDelConfirmDialog = false;
            if (deleteConfirmed && narrationIdToDelete != 0)
            {
                await NarrationRepository.DeleteNarrationAsync(narrationIdToDelete);
                Orphan.Narrations = await NarrationRepository.GetOrphanNarrations(Orphan.OrphanID);
                Toaster.Add("Narration deleted.", MatToastType.Success);
                StateHasChanged();
            }
            narrationIdToDelete = 0;
        }

        public void TabHeaderEventCallbackHandler()
        {

        }
    }
}
