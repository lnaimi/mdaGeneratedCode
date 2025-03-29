

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
        
        public class AccountService : IAccountService {


            private readonly IAccountRepository _accountRepository;

            private readonly IUserRepository _userRepository;

            private readonly IAcountActionRepository _acountactionRepository;

            public AccountService() { }
            public AccountService(IAccountRepository accountRepository, IUserRepository userRepository, IAcountActionRepository acountactionRepository)
                
            {
                #region Constructor initialisation
                //
                _accountRepository = accountRepository;
                _userRepository = userRepository;
                _acountactionRepository = acountactionRepository;
                
                #endregion
            }

            public Account GetAccount(Account account)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Account> GetAccountAsync(Account account)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Account AddAccount(Account account)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<Account> AddAccountAsync(Account account)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int UpdateAccount(Account account)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> UpdateAccountAsync(Account account)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int DeleteAccount(Account account)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> DeleteAccountAsync(Account account)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public User GetUser(User user)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<User> GetUserAsync(User user)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public User AddUser(User user)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<User> AddUserAsync(User user)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int UpdateUser(User user)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> UpdateUserAsync(User user)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int DeleteUser(User user)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> DeleteUserAsync(User user)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public AcountAction GetAcountAction(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<AcountAction> GetAcountActionAsync(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public AcountAction AddAcountAction(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public Task<AcountAction> AddAcountActionAsync(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int UpdateAcountAction(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> UpdateAcountActionAsync(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            public int DeleteAcountAction(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return 0;
            }

            public Task<int> DeleteAcountActionAsync(AcountAction acountAction)
            {
                #region Operation body
                // 
                #endregion
                return null;
            }

            
        }

    }
        