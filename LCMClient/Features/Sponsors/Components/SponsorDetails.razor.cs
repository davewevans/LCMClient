using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Features.Sponsors.Models;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Navigations;
using System.Threading.Tasks;

namespace LCMClient.Features.Sponsors.Components
{
    public partial class SponsorDetails
    {
        [Inject]
        public ISponsorRepository sponsorRepository { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Parameter]
        public int Id { get; set; }

        public SfTab sfTabs;

        private bool showDelConfirmDialog = false;

        private SponsorDetailsModel sponsorDetails;

        protected override async Task OnInitializedAsync()
        {
            sponsorDetails = await sponsorRepository.GetSponsorDetailsAsync(Id);
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed)
            {
                await sponsorRepository.DeleteSponsorAsync(sponsorDetails.SponsorID);                
                Toaster.Add("Sponsor deleted.", MatToastType.Success);
                NavigationManager.NavigateTo("/sponsors");
            }
        }

        protected void OnEditClick()
        {
            sfTabs.Select(1);
        }

        protected void OnDeleteClick()
        {
            showDelConfirmDialog = true;
        }

        public async Task HandleSponsorEditedCallBack()
        {
             sponsorDetails = await sponsorRepository.GetSponsorDetailsAsync(Id);
        }

    }
}
