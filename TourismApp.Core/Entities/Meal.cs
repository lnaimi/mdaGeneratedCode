
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Meal : BaseEntity
	{
	
		public  Menu { get; set;}
		public  IncludedMeal { get; set;}
	

	
		public Meal()
		{
			// Needed by EF
		}
		
		public Meal( menu,  includedMeal)
		{
			
			this.Menu = menu;
			
			this.IncludedMeal = includedMeal;
			
		}

	
	
 
	}
}	
       