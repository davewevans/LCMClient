using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanPDFs
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        private string selectedValue;

        [Inject] public IOrphanRepository OrphanRepository { get; set; }

        [Inject] public IPDFRepository PdfRepository { get; set; }

        [Inject] public IMatToaster Toaster { get; set; }

        public string SelectedLabel { get; set; } = "Send to one sponsor";
        public string SelectedOption { get; set; } = "1";

        private bool showDelConfirmDialog = false;

        private int pdfIdToEdit = 0;

        protected override async Task OnInitializedAsync()
        {
            Orphan.PDFs = await PdfRepository.GetOrphanPDFsAsync(Orphan.OrphanID);
            StateHasChanged();

            if (Orphan?.Sponsors == null) return;
            foreach (var sponsor in Orphan.Sponsors)
            {
                sponsor.FullName = $"{sponsor.FirstName} {sponsor.LastName} ({sponsor.Email})";
            }
        }

        private async Task HandlePostUpload(OrphanDetailsModel orphan)
        {
            Orphan.PDFs = await PdfRepository.GetOrphanPDFsAsync(orphan.OrphanID);
            StateHasChanged();
        }

        private void OnDeletePDF(int id)
        {
            pdfIdToEdit = id;
            showDelConfirmDialog = true;
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            showDelConfirmDialog = false;
            if (deleteConfirmed && pdfIdToEdit != 0)
            {
                await PdfRepository.DeletePDFAsync(pdfIdToEdit);
                Orphan.PDFs = await PdfRepository.GetOrphanPDFsAsync(Orphan.OrphanID);             
                Toaster.Add("PDF Deleted.", MatToastType.Success);
                StateHasChanged();
            }
            pdfIdToEdit = 0;
        }
    }
}
