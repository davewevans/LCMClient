using LCMClient.Features.Orphans.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository.Contracts
{
    public interface IPDFRepository
    {
        Task<string> UploadPDFAsync(PDFCreationModel pdfCreation, byte[] fileBytes);

        Task<List<PDFModel>> GetOrphanPDFsAsync(int orphanId);

        Task DeletePDFAsync(int pdfID);
    }
}