﻿using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanGuardian
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Parameter]
        public EventCallback HandleOrphanEdited { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepository { get; set; }       

        private object TextModel = new
        {
            placeholder = "Relationship"
        };

        protected override void OnInitialized()
        {
            Orphan.RelationshipToGuardian = Orphan.RelationshipToGuardian ?? "";
        }

        protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

        private ViewMode viewMode = ViewMode.List;

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
                Orphan.Guardian = await OrphanRepository.GetOrphanGuardianAsync(Orphan.OrphanID);
                StateHasChanged();

                await HandleOrphanEdited.InvokeAsync("");
            }
        }
        private void OnRemoveClick()
        {
            DeleteConfirmationDialog.ShowDialog();
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "guardianID");
                await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "relationshipToGuardian");
                Orphan.Guardian = await OrphanRepository.GetOrphanGuardianAsync(Orphan.OrphanID);
                StateHasChanged();

                await HandleOrphanEdited.InvokeAsync("");

            }
        }

        protected async Task RelationshipEditHandler()
        {    
            await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "relationshipToGuardian", Orphan.RelationshipToGuardian);          
            StateHasChanged();
            await HandleOrphanEdited.InvokeAsync("");
        }
    }
}