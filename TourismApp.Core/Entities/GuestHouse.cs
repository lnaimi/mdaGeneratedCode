
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class GuestHouse : BaseEntity
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
       