

using System.Threading.Tasks;
using SmartTourismApp.Core.Entities;

namespace SmartTourismApp.Core.Interfaces
{
    public interface IAccountService 
    {
         Account GetAccount(Account account);
         Task<Account> GetAccountAsync(Account account);
         Account AddAccount(Account account);
         Task<Account> AddAccountAsync(Account account);
         int UpdateAccount(Account account);
         Task<int> UpdateAccountAsync(Account account);
         int DeleteAccount(Account account);
         Task<int> DeleteAccountAsync(Account account);
         User GetUser(User user);
         Task<User> GetUserAsync(User user);
         User AddUser(User user);
         Task<User> AddUserAsync(User user);
         int UpdateUser(User user);
         Task<int> UpdateUserAsync(User user);
         int DeleteUser(User user);
         Task<int> DeleteUserAsync(User user);
         AcountAction GetAcountAction(AcountAction acountAction);
         Task<AcountAction> GetAcountActionAsync(AcountAction acountAction);
         AcountAction AddAcountAction(AcountAction acountAction);
         Task<AcountAction> AddAcountActionAsync(AcountAction acountAction);
         int UpdateAcountAction(AcountAction acountAction);
         Task<int> UpdateAcountActionAsync(AcountAction acountAction);
         int DeleteAcountAction(AcountAction acountAction);
         Task<int> DeleteAcountActionAsync(AcountAction acountAction);
        
    }
}
        