
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class ArtificialAttraction : Attraction
	{
	
		public Time OpeningTime { get; set;}
		public Time ClosingTime { get; set;}
		public DateTime ConstructionDate { get; set;}
	

	
		public ArtificialAttraction()
		{
			// Needed by EF
		}
		
		public ArtificialAttraction(Time openingTime, Time closingTime, DateTime constructionDate)
		{
			
			this.OpeningTime = openingTime;
			
			this.ClosingTime = closingTime;
			
			this.ConstructionDate = constructionDate;
			
		}

	
	
 
	}
}	
       