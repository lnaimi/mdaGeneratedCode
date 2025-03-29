
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class CityBus : BaseEntity
	{
	
		public  City { get; set;}
	

	
		public CityBus()
		{
			// Needed by EF
		}
		
		public CityBus( city)
		{
			
			this.City = city;
			
		}

	
	
 
	}
}	
       