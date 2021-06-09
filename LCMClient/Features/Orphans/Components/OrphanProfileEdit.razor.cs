using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using LCMClient.Annotations;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanProfileEdit : IDisposable
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Parameter]
        public EventCallback<OrphanDetailsModel> HandleOrphanEdited { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Inject] public IOrphanRepository OrphanRepo { get; set; }
        
        //public INotifyPropertyChanged LCMStatusPropertyChanged;

        private Dictionary<string, object> additionalAttributes = new () { { "disabled", true } };

        protected override void OnInitialized()
        {
            Orphan.PropertyChanged += async (sender, e) => { 
                await InvokeAsync(() =>
                {
                    additionalAttributes["disabled"] = !Orphan.LCMStatus.ToLower().Contains("inactive");
                    StateHasChanged();
                });
            };
            base.OnInitialized();
        }

        protected override Task OnParametersSetAsync()
        {
            additionalAttributes["disabled"] = !Orphan.LCMStatus.ToLower().Contains("inactive");
            return base.OnParametersSetAsync();
        }

        private async Task HandleValidSubmit()
        {
            var orphanEdit = new OrphanEditModel
            {
                FirstName = Orphan.FirstName,
                MiddleName = Orphan.MiddleName,
                LastName = Orphan.LastName,
                DateOfBirth = Orphan.DateOfBirth,
                Gender = Orphan.Gender,
                LCMStatus = Orphan.LCMStatus,
                ExitStatus =  Orphan.ExitStatus,
                ProfileNumber = Orphan.ProfileNumber,
                GuardianID = Orphan.GuardianID,
                Location = Orphan.Location,
                RelationshipToGuardian = Orphan.RelationshipToGuardian,
                Condition = Orphan.Condition,
                YearOfAdmission = Orphan.YearOfAdmission
            };

            await OrphanRepo.UpdateOrphanAsync(Orphan.OrphanID, orphanEdit);
            Toaster.Add("Record updated.", MatToastType.Success);


            await HandleOrphanEdited.InvokeAsync(Orphan);
        }


        private async Task HandleProfileChanged(OrphanDetailsModel orphan)
        {
            // StateHasChanged(); invoked auto
            await HandleOrphanEdited.InvokeAsync(Orphan);
        }

        private void OnLCMStatusChangedHandler()
        {
            if (Orphan.LCMStatus.ToLower().Contains("inactive"))
            {
                Toaster.Add("containts inactive.", MatToastType.Success);
            }
            else
            {
                Toaster.Add("no inactive.", MatToastType.Warning);
            }
        }
        
        public void Dispose()
        {
            Toaster?.Dispose();
            // Orphan.PropertyChanged -= OnPropertyChangedHandler;
        }
    }
}
