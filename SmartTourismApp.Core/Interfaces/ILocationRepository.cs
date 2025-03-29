

using System.Threading.Tasks;
using SmartTourismApp.SharedKernel.Interfaces;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface ILocationRepository : IAsyncRepository<Location>, IRepository<Location> 
    {
         Location GetByIdWithAcountAction(int id);
         Task<Location> GetByIdWithAcountActionAsync(int id);
        
    }
}
        