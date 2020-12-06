using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanCreate
    {
        public OrphanCreationModel NewOrphan { get; set; } = new OrphanCreationModel();

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepo { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void HandleValidSubmit()
        {
            OrphanRepo.AddOrphanAsync(NewOrphan);
            // NavigationManager.NavigateTo("/CreateOrphan");
            NewOrphan = new OrphanCreationModel();
            Toaster.Add($"{ NewOrphan.FirstName } added.", MatToastType.Success);
        }

        public void DatePickerChanged()
        {

        }
    }
}
