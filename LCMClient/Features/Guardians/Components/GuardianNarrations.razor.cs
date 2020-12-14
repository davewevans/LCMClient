using LCMClient.Features.Guardians.Models;
using LCMClient.Features.Shared.Enums;
using LCMClient.Features.Shared.Narrations;
using LCMClient.Features.Shared.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Guardians.Components
{
    public partial class GuardianNarrations
    {
        [Parameter]
        public GuardianDetailsModel Guardian { get; set; }

        [Parameter]
        public EventCallback HandleNarrationsUpdated { get; set; }

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

        protected override async Task OnParametersSetAsync()
        {
            if (Guardian?.Narrations is null)
            {
                Guardian.Narrations = await NarrationRepository.GetGuardianNarrations(Guardian.GuardianID);
            }
        }

        private void OnAddClick()
        {
            viewMode = ViewMode.AddNew;
        }

        public async Task OnAddNewComplete(bool recordAdded)
        {
            viewMode = ViewMode.List;
            if (recordAdded)
            {
                Guardian.Narrations = await NarrationRepository.GetGuardianNarrations(Guardian.GuardianID);
                await HandleNarrationsUpdated.InvokeAsync();
                StateHasChanged();
            }
        }

        private void OnEditClick(NarrationModel narrationRecord)
        {
            showDelConfirmDialog = false;
            narrationEdit = new NarrationEditModel
            {
                Subject = narrationRecord.Subject,
                Note = narrationRecord.Note,
                GuardianID = narrationRecord.GuardianID,
                EntryDate = narrationRecord.EntryDate
            };
            narrationIdToEdit = narrationRecord.NarrationID;
            viewMode = ViewMode.Edit;
        }

        private async Task OnEditComplete(bool recordEdited)
        {
            narrationIdToEdit = 0;
            showDelConfirmDialog = false;
            viewMode = ViewMode.List;
            Guardian.Narrations = await NarrationRepository.GetGuardianNarrations(Guardian.GuardianID);
            StateHasChanged();
        }

        private void OnDeleteClick(int narrationId)
        {
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
                Guardian.Narrations = await NarrationRepository.GetGuardianNarrations(Guardian.GuardianID);
                await HandleNarrationsUpdated.InvokeAsync();
                Toaster.Add("Narration deleted.", MatToastType.Success);
                StateHasChanged();
            }
            narrationIdToDelete = 0;
        }
    }
}

