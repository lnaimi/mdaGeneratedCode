
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class UserPaymentOption
	{
	
		public String Id { get; set;}
		public  PaymentOption { get; set;}
	

	
		public UserPaymentOption()
		{
			// Needed by EF
		}
		
		public UserPaymentOption(String id,  paymentOption)
		{
			
			this.Id = id;
			
			this.PaymentOption = paymentOption;
			
		}

	
	
 
	}
}	
       