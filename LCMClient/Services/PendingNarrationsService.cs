using System;
using System.Threading.Tasks;
using LCMClient.Features.Shared.Repository.Contracts;

namespace LCMClient.Services
{
    public class PendingNarrationsService
    {
        public event Action OnChange;
        
        private readonly INarrationRepository narrationRepository;

        public PendingNarrationsService(INarrationRepository narrationRepository)
        {
            this.narrationRepository = narrationRepository;
        }
        public string PendingNarrationsCount { get; set; }
        
        public async Task SetPendingNarrationsCount()
        {
            int count = await narrationRepository.GetPendingNarrationsCount();
            PendingNarrationsCount = count.ToString();
            OnChange?.Invoke();;
        }
    }
}