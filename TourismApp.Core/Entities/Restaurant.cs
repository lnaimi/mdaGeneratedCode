
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Restaurant : Gastronomy
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
       