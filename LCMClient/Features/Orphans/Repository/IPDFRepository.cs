using LCMClient.Features.Orphans.Models;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository
{
    public interface IPDFRepository
    {
        Task<string> UploadPDFAsync(PDFCreationModel pdfCreation, byte[] fileBytes);

        Task DeletePDFAsync(int pdfID);
    }
}