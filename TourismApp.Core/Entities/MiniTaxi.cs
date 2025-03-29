
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class MiniTaxi : BaseEntity, IAggregateRoot
	{
	
		public  City { get; set;}
	

	
		public MiniTaxi()
		{
			// Needed by EF
		}
		
		public MiniTaxi( city)
		{
			
			this.City = city;
			
		}

	
	
 
	}
}	
       