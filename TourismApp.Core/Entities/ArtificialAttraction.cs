
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class ArtificialAttraction : BaseEntity, IAggregateRoot
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
       