using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanDetails
    {
        string fullNameStyle = "bg-gray-200 p-2";
        static Random randomizer = new Random();
        string profileBgClass = "bg-gradient-1";

        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepo { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public SfTab sfTabs;

        private bool isEditMode = false;

        public OrphanDetailsModel Orphan { get; set; }

        private bool showDelConfirmDialog = false;

        public OrphanSummary Summary { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orphan = await OrphanRepo.GetOrphanDetailsAsync(Id);
            if (Orphan == null) return;

            GenerateProfileBackground(); 
            PopulateSummary();
            SetNameBgColorBasedOnGender();            
        }

        private void PopulateSummary()
        {
            Summary = new OrphanSummary
            {
                HasGuardian = Orphan.Guardian != null ? "Yes" : "No",
                HasGuardianStyle = Orphan.Guardian != null ? "text-green-700 font-semibold" : "text-red-700 font-semibold",
                NumOfSponsors = Orphan.Sponsors.Count(),
                Birthdate = Orphan.DateOfBirth,
                LCMStatus = Orphan.LCMStatus,
                LCMStatusStyle = Orphan.LCMStatus.ToLower().Equals("active") ? "px-2 inline-flex text-sm leading-5 font-semibold rounded-full bg-green-100 text-green-800" : "px-2 inline-flex text-sm leading-5 font-semibold rounded-full bg-red-100 text-red-800",
                ProfileNumber = Orphan.ProfileNumber,
                Condition = Orphan.Condition,
                YearOfAdmission = Orphan.YearOfAdmission != null ? $"{Orphan.YearOfAdmission:yyyy}" : ""
            };
        }

        private void GenerateProfileBackground()
        {
            int numberOfGradients = 40;
            profileBgClass = $"bg-gradient-{randomizer.Next(1, numberOfGradients + 1)}";
        }

        private void SetNameBgColorBasedOnGender()
        {
            if (Orphan.Gender.ToLower().Equals("male") || Orphan.Gender.ToLower().Equals("female"))
            {
                fullNameStyle = Orphan.Gender.ToLower().Equals("male") ? "bg-blue-200 p-2" : "bg-pink-200 p-2";
            }
        }

        protected void OnEditClick()
        {
            isEditMode = true;
            sfTabs.Select(0);
        }

        protected void OnDeleteClick()
        {
            showDelConfirmDialog = true;
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed)
            {
                await OrphanRepo.DeleteOrphanAsync(Orphan.OrphanID);
                Toaster.Add("Orphan deleted.", MatToastType.Success);
                NavigationManager.NavigateTo("/orphans");
            }
        }

        public async Task HandleOrphanEdited()
        {
            Orphan = await OrphanRepo.GetOrphanDetailsAsync(Id);
            if (Orphan == null) return;
            PopulateSummary();
            GenerateProfileBackground();
            SetNameBgColorBasedOnGender();
            isEditMode = false;
            StateHasChanged();
        }
    }
}
