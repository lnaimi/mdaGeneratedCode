

using System.Threading.Tasks;
using SmartTourismApp.SharedKernel.Interfaces;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface IAmenityRepository : IAsyncRepository<Amenity>, IRepository<Amenity> 
    {
         Amenity GetByIdWithAmenity(int id);
         Task<Amenity> GetByIdWithAmenityAsync(int id);
         Amenity GetByIdWithAmenity(int id);
         Task<Amenity> GetByIdWithAmenityAsync(int id);
         Amenity GetByIdWithRooms(int id);
         Task<Amenity> GetByIdWithRoomsAsync(int id);
        
    }
}
        