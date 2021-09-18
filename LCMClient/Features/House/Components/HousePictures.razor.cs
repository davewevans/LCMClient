using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanPictures
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject] public IOrphanRepository OrphanRepository { get; set; }

        [Inject] public IPictureRepository PictureRepository { get; set; }

        [Inject] public IMatToaster Toaster { get; set; }

        private bool showDelConfirmDialog = false;

        private int pictureIdToEdit = 0;

        private async Task HandlePostUpload(OrphanDetailsModel orphan)
        {
            Orphan.Pictures = await OrphanRepository.GetOrphanPicturesAsync(Orphan.OrphanID);
            StateHasChanged();
        }

        private void OnDeleteHandler(MouseEventArgs args, int id)
        {
            showDelConfirmDialog = true;
            pictureIdToEdit = id;
        }


        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed && pictureIdToEdit != 0)
            {
                await PictureRepository.DeletePictureAsync(pictureIdToEdit);
                Orphan.Pictures = await OrphanRepository.GetOrphanPicturesAsync(Orphan.OrphanID);
                Toaster.Add("Picture deleted.", MatToastType.Success);
                StateHasChanged();
            }
            pictureIdToEdit = 0;
        }
    }
}
