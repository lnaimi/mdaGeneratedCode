
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Restaurant : BaseEntity
	{
	
		public  TypeOfCuisine { get; set;}
	

	
		public Restaurant()
		{
			// Needed by EF
		}
		
		public Restaurant( typeOfCuisine)
		{
			
			this.TypeOfCuisine = typeOfCuisine;
			
		}

	
	
 
	}
}	
       