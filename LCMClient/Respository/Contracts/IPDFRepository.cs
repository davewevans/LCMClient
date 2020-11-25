using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMClient.Repository.Contracts
{
    public interface IPDFRepository
    {
        Task<string> UploadPDFAsync(PDFCreation pdfCreation, byte[] fileBytes);

        Task DeletePDFAsync(int pdfID);
    }
}