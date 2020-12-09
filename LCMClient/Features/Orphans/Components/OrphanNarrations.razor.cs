﻿using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanNarrations
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject]
        public INarrationRepository NarrationRepository { get; set; }

        protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

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
            narrationIdToEdit = 0;
            viewMode = ViewMode.List;
            Orphan.Narrations = await NarrationRepository.GetOrphanNarrations(Orphan.OrphanID);
            StateHasChanged();
        }

        private void OnDeleteClick(int narrationId)
        {
            narrationIdToDelete = narrationId;
            DeleteConfirmationDialog.ShowDialog();
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            if (deleteConfirmed && narrationIdToDelete != 0)
            {
                await NarrationRepository.DeleteNarrationAsync(narrationIdToDelete);
                Orphan.Narrations = await NarrationRepository.GetOrphanNarrations(Orphan.OrphanID);
                StateHasChanged();
            }
            narrationIdToDelete = 0;
        }
    }
}