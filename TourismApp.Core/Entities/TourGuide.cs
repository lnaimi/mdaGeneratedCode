
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class TourGuide : BaseEntity
	{
	
		public  TypeOfTour { get; set;}
	

	
		public TourGuide()
		{
			// Needed by EF
		}
		
		public TourGuide( typeOfTour)
		{
			
			this.TypeOfTour = typeOfTour;
			
		}

	
	
 
	}
}	
       