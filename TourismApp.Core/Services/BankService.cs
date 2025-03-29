
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class BankService : IBankService
	{
		private readonly IBankRepository _bankRepository;
		
		public BankService(IBankRepository bankRepository)
		{
			_bankRepository = bankRepository;
		}
	}
}	
       