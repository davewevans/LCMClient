using LCMClient.Features.Orphans.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanProfile
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Parameter]
        public EventCallback HandleOrphanEdited { get; set; }

        [Parameter]
        public bool EditMode { get; set; }

        private string editViewIcon = "fa fa-edit";

        private string editViewText = "Edit";

        private string headerText = "";

        protected override void OnParametersSet()
        {
            UpdateBtnIconAndText();
            headerText = $"{Orphan.FirstName}'s Profile";
        }

        public void ToggleEditMode()
        {
            EditMode = !EditMode;
            UpdateBtnIconAndText();
        }

        private void UpdateBtnIconAndText()
        {
            editViewIcon = EditMode ? "fa fa-times" : "fa fa-edit";
            editViewText = EditMode ? "Close" : "Edit";
        }

        public async Task HandleOrphanEditedByChild(OrphanDetailsModel orphan)
        {
            await HandleOrphanEdited.InvokeAsync("");
        }
    }
}
