
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Lodge : Amenity
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
       