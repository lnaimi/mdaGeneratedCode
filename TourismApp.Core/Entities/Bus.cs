
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Bus : BaseEntity
	{
	
		public  DepartureCity { get; set;}
		public  ArrivalCity { get; set;}
	

	
		public Bus()
		{
			// Needed by EF
		}
		
		public Bus( departureCity,  arrivalCity)
		{
			
			this.DepartureCity = departureCity;
			
			this.ArrivalCity = arrivalCity;
			
		}

	
	
 
	}
}	
       