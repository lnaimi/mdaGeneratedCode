
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Lodge : BaseEntity
	{
	
		public  RecreationalFacilities { get; set;}
	

	
		public Lodge()
		{
			// Needed by EF
		}
		
		public Lodge( recreationalFacilities)
		{
			
			this.RecreationalFacilities = recreationalFacilities;
			
		}

	
	
 
	}
}	
       