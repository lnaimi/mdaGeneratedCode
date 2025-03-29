
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Transport : BaseEntity
	{
	
		public String Id { get; set;}
		public Common Classes App.Pricing Price { get; set;}
		public Time Duration { get; set;}
	

	
		public Transport()
		{
			// Needed by EF
		}
		
		public Transport(String id, Common Classes App.Pricing price, Time duration)
		{
			
			this.Id = id;
			
			this.Price = price;
			
			this.Duration = duration;
			
		}

	
	
 
	}
}	
       