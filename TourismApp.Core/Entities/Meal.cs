
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Meal : AmenityService
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
       