

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.Core.Entities;
    using SmartTourismApp.Core.Interfaces;
    
    namespace SmartTourismApp.Core.Services
    {
        
        public class LocationService : ILocationService {


            private readonly IAttractionRepository _attractionRepository;

            private readonly ILocationRepository _locationRepository;

            private readonly IAmenityRepository _amenityRepository;

            public LocationService() { }
            public LocationService(IAttractionRepository attractionRepository, ILocationRepository locationRepository, IAmenityRepository amenityRepository)
                
            {
                #region Constructor initialisation
                //
                _attractionRepository = attractionRepository;
                _locationRepository = locationRepository;
                _amenityRepository = amenityRepository;
                
                #endregion
            }

            public Attraction GetAttraction(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Attraction> GetAttractionAsync(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Attraction AddAttraction(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Attraction> AddAttractionAsync(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int UpdateAttraction(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> UpdateAttractionAsync(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int DeleteAttraction(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> DeleteAttractionAsync(Attraction attraction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Location GetLocation(Location location)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Location> GetLocationAsync(Location location)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Location AddLocation(Location location)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Location> AddLocationAsync(Location location)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int UpdateLocation(Location location)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> UpdateLocationAsync(Location location)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int DeleteLocation(Location location)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> DeleteLocationAsync(Location location)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Amenity GetAmenity(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Amenity> GetAmenityAsync(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Amenity AddAmenity(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Amenity> AddAmenityAsync(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int UpdateAmenity(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> UpdateAmenityAsync(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int DeleteAmenity(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> DeleteAmenityAsync(Amenity amenity)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            
        }

    }
        