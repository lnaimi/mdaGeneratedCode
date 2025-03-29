

using System.Threading.Tasks;
using SmartTourismApp.SharedKernel.Interfaces;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User> 
    {
        
    }
}
        