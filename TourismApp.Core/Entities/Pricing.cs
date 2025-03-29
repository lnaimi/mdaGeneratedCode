
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Pricing
	{
	
		public String Id { get; set;}
		public  UnitOfMeasurement { get; set;}
		public  Money { get; set;}
	

	
		public Pricing()
		{
			// Needed by EF
		}
		
		public Pricing(String id,  unitOfMeasurement,  money)
		{
			
			this.Id = id;
			
			this.UnitOfMeasurement = unitOfMeasurement;
			
			this.Money = money;
			
		}

	
	
 
	}
}	
       