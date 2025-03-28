
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Hotel : Amenity
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
       