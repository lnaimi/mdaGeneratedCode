
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Musem : BaseEntity
	{
	
		public int NumberOfExhibits { get; set;}
	

	
		public Musem()
		{
			// Needed by EF
		}
		
		public Musem(int numberOfExhibits)
		{
			
			this.NumberOfExhibits = numberOfExhibits;
			
		}

	
	
 
	}
}	
       