

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
        
        public class AccountRepository : EfRepository<Account>, IAccountRepository {


            public AccountRepository(SmartTourismAppContext smartTourismAppContext)
                 : base(smartTourismAppContext)
                    
            {
                #region Constructor initialisation
                //
                
                #endregion
            }

            public Account GetByIdWithUser(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Account> GetByIdWithUserAsync(int id)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            
        }

    }
        