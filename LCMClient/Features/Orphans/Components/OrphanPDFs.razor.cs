using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
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

        public string SelectedLabel { get; set; } = "Send to one sponsor";
        public string SelectedOption { get; set; } = "1";

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

        private async Task OnDeletePDF(int id)
        {
            await PdfRepository.DeletePDFAsync(id);
            Orphan.PDFs = await PdfRepository.GetOrphanPDFsAsync(Orphan.OrphanID);
            StateHasChanged();
        }
    }
}
