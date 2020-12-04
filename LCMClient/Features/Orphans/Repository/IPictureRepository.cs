using LCMClient.Features.Orphans.Models;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository
{
    public interface IPictureRepository
    {
        Task<string> UploadImageAsync(PictureCreationModel picCreation, byte[] fileBytes);
    }
}
