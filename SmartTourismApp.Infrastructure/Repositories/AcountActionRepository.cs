

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
        
        public class AcountActionRepository : EfRepository<AcountAction>, IAcountActionRepository {


            public AcountActionRepository(SmartTourismAppContext smartTourismAppContext)
                 : base(smartTourismAppContext)
                    
            {
                #region Constructor initialisation
                //
                
                #endregion
            }

            public AcountAction GetByIdWithAccount(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<AcountAction> GetByIdWithAccountAsync(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            
        }

    }
        