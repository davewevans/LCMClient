using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanProfileEdit
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Parameter]
        public EventCallback<OrphanDetailsModel> HandleOrphanEdited { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Inject] public IOrphanRepository OrphanRepo { get; set; }


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

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        private async Task HandleProfileChanged(OrphanDetailsModel orphan)
        {
            // StateHasChanged(); invoked auto
            await HandleOrphanEdited.InvokeAsync(Orphan);
        }
    }
}
