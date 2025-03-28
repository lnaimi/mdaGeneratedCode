
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class GuestHouse : Amenity
	{
	
		public int NumberOfFloors { get; set;}
	

	
		public GuestHouse()
		{
			// Needed by EF
		}
		
		public GuestHouse(int numberOfFloors)
		{
			
			this.NumberOfFloors = numberOfFloors;
			
		}

	
	
 
	}
}	
       