

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
        
        public class UserRepository : EfRepository<User>, IUserRepository {


            public UserRepository(SmartTourismAppContext smartTourismAppContext)
                 : base(smartTourismAppContext)
                    
            {
                #region Constructor initialisation
                //
                
                #endregion
            }

            
        }

    }
        