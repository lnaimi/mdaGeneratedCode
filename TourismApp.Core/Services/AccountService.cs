
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AccountService : IAccountService
	{
		private readonly IAccountRepository _accountRepository;
		
		public AccountService(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}
	}
}	
       