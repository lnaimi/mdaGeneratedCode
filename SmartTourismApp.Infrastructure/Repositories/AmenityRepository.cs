

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.Core.Interfaces;
    using SmartTourismApp.Core.Entities;
    
    namespace SmartTourismApp.Infrastructure.Repositories
    {
        
        public class AmenityRepository : EfRepository<Amenity>, IAmenityRepository {


            public AmenityRepository(SmartTourismAppContext smartTourismAppContext)
                 : base(smartTourismAppContext)
                    
            {
                #region Constructor initialisation
                //
                
                #endregion
            }

            public Amenity GetByIdWithAmenity(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Amenity> GetByIdWithAmenityAsync(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Amenity GetByIdWithAmenity(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Amenity> GetByIdWithAmenityAsync(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Amenity GetByIdWithRooms(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Amenity> GetByIdWithRoomsAsync(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            
        }

    }
        