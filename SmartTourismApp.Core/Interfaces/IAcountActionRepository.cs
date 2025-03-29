

using System.Threading.Tasks;
using SmartTourismApp.SharedKernel.Interfaces;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface IAcountActionRepository : IAsyncRepository<AcountAction>, IRepository<AcountAction> 
    {
         AcountAction GetByIdWithAccount(int id);
         Task<AcountAction> GetByIdWithAccountAsync(int id);
        
    }
}
        