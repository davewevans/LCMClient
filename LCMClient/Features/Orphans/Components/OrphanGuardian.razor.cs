using System.Collections.Generic;
using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Features.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using LCMClient.Helpers;
using Microsoft.JSInterop;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanGuardian
    {
        [Parameter] public OrphanDetailsModel Orphan { get; set; }

        [Parameter] public EventCallback HandleOrphanEdited { get; set; }

        [Inject] public IOrphanRepository OrphanRepository { get; set; }

        [Inject] protected IMatToaster Toaster { get; set; }

        [Inject] protected IJSRuntime JsRuntime { get; set; }

        private List<OrphanHistoryDTO> orphanHistory;

        private string showHideHistoryButtonText = "Show History";

        private string showHideHistoryButtonIcon = "fa fa-history";

        private bool showHistory = false;

        private bool showDelConfirmDialog = false;

        private object TextModel = new
        {
            placeholder = "Relationship"
        };

        protected override async Task OnInitializedAsync()
        {
            Orphan.RelationshipToGuardian = Orphan.RelationshipToGuardian ?? "";

            orphanHistory = await OrphanRepository.GetOrphanHistoryAsync(Orphan.OrphanID);

            if (orphanHistory != null)
            {
                foreach (var history in orphanHistory)
                {
                    await JsRuntime.ConsoleLog($"history: {history.GuardianName}");
                }
            }
            else
            {
                await JsRuntime.ConsoleLog("orphan history is null");
            }
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
            showDelConfirmDialog = true;
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed)
            {
                await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "guardianID");
                await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "relationshipToGuardian");


                // add new orphan history
                var newOrphanHistory = new OrphanHistoryDTO
                {
                    OrphanID = Orphan.OrphanID,
                    GuardianID = Orphan.GuardianID,
                    RelationshipToGuardian = Orphan.RelationshipToGuardian
                };
                await OrphanRepository.AddOrphanHistoryAsync(newOrphanHistory);
                
                // update history for display
                orphanHistory = await OrphanRepository.GetOrphanHistoryAsync(Orphan.OrphanID);
                
                Orphan.Guardian = await OrphanRepository.GetOrphanGuardianAsync(Orphan.OrphanID);
                Toaster.Add("Record deleted.", MatToastType.Success);
                
                StateHasChanged();

                await HandleOrphanEdited.InvokeAsync("");
            }
        }
        
        private void ShowHideHistoryHandler()
        {
            showHideHistoryButtonText = showHistory ? "Show History" : "Hide History";
            showHideHistoryButtonIcon = showHistory ? "fa fa-history" : "fa fa-eye-slash";
            showHistory = !showHistory;
        }

        protected async Task RelationshipEditHandler()
        {
            await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "relationshipToGuardian",
                Orphan.RelationshipToGuardian);

            StateHasChanged();
            await HandleOrphanEdited.InvokeAsync("");
        }
    }
}