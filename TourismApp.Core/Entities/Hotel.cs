
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Hotel : BaseEntity
	{
	
		public  Classification { get; set;}
		public  RecreationalFacilities { get; set;}
	

	
		public Hotel()
		{
			// Needed by EF
		}
		
		public Hotel( classification,  recreationalFacilities)
		{
			
			this.Classification = classification;
			
			this.RecreationalFacilities = recreationalFacilities;
			
		}

	
	
 
	}
}	
       