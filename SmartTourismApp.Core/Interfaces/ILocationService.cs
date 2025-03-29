

using System.Threading.Tasks;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface ILocationService 
    {
         Attraction GetAttraction(Attraction attraction);
         Task<Attraction> GetAttractionAsync(Attraction attraction);
         Attraction AddAttraction(Attraction attraction);
         Task<Attraction> AddAttractionAsync(Attraction attraction);
         int UpdateAttraction(Attraction attraction);
         Task<int> UpdateAttractionAsync(Attraction attraction);
         int DeleteAttraction(Attraction attraction);
         Task<int> DeleteAttractionAsync(Attraction attraction);
         Location GetLocation(Location location);
         Task<Location> GetLocationAsync(Location location);
         Location AddLocation(Location location);
         Task<Location> AddLocationAsync(Location location);
         int UpdateLocation(Location location);
         Task<int> UpdateLocationAsync(Location location);
         int DeleteLocation(Location location);
         Task<int> DeleteLocationAsync(Location location);
         Amenity GetAmenity(Amenity amenity);
         Task<Amenity> GetAmenityAsync(Amenity amenity);
         Amenity AddAmenity(Amenity amenity);
         Task<Amenity> AddAmenityAsync(Amenity amenity);
         int UpdateAmenity(Amenity amenity);
         Task<int> UpdateAmenityAsync(Amenity amenity);
         int DeleteAmenity(Amenity amenity);
         Task<int> DeleteAmenityAsync(Amenity amenity);
        
    }
}
        