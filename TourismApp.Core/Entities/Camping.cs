
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Camping : Amenity
	{
	
		public boolean Gated { get; set;}
	

	
		public Camping()
		{
			// Needed by EF
		}
		
		public Camping(boolean gated)
		{
			
			this.Gated = gated;
			
		}

	
	
 
	}
}	
       