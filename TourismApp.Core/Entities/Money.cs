
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Money
	{
	
		public decimal Amount { get; set;}
		public  Currency { get; set;}
	

	
		public Money()
		{
			// Needed by EF
		}
		
		public Money(decimal amount,  currency)
		{
			
			this.Amount = amount;
			
			this.Currency = currency;
			
		}

	
	
 
	}
}	
       