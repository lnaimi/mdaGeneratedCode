

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
        
        public class LocationRepository : EfRepository<Location>, ILocationRepository {


            public LocationRepository(SmartTourismAppContext smartTourismAppContext)
                 : base(smartTourismAppContext)
                    
            {
                #region Constructor initialisation
                //
                
                #endregion
            }

            public Location GetByIdWithAcountAction(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Location> GetByIdWithAcountActionAsync(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            
        }

    }
        