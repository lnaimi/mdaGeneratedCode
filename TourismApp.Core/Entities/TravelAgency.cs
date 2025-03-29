
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class TravelAgency : BaseEntity
	{
	
		public int NumberOfOffices { get; set;}
	

	
		public TravelAgency()
		{
			// Needed by EF
		}
		
		public TravelAgency(int numberOfOffices)
		{
			
			this.NumberOfOffices = numberOfOffices;
			
		}

	
	
 
	}
}	
       