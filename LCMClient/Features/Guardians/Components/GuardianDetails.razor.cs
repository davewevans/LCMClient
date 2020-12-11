using LCMClient.Features.Guardians.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Guardians.Components
{
    public partial class GuardianDetails
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IGuardianRepository guardianRepository { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        public SfTab sfTabs;

        private bool showDelConfirmDialog = false;

        private GuardianDetailsModel guardianDetails;

        protected override async Task OnInitializedAsync()
        {
            guardianDetails = await guardianRepository.GetGuardianDetailsAsync(Id);
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed)
            {
                await guardianRepository.DeleteGuardianAsync(guardianDetails.GuardianID);
                Toaster.Add("Guardian deleted.", MatToastType.Success);
                NavigationManager.NavigateTo("/guardians");
            }
        }

        protected void OnEditClick()
        {            
            sfTabs.Select(2);
        }

        protected void OnDeleteClick()
        {
            showDelConfirmDialog = true;
        }

        public async Task HandleGuardianEditedCallback()
        {
            guardianDetails = await guardianRepository.GetGuardianDetailsAsync(Id);
        }

        public async Task HandleNarrationsUpdatedCallback()
        {
            guardianDetails = await guardianRepository.GetGuardianDetailsAsync(Id);
        }
    }
}
