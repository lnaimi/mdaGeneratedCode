

using System.Threading.Tasks;
using SmartTourismApp.SharedKernel.Interfaces;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface IAccountRepository : IAsyncRepository<Account>, IRepository<Account> 
    {
         Account GetByIdWithUser(int id);
         Task<Account> GetByIdWithUserAsync(int id);
        
    }
}
        