
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Mountain : BaseEntity
	{
	
		public float Height { get; set;}
		public  ClimbingOpportunities { get; set;}
	

	
		public Mountain()
		{
			// Needed by EF
		}
		
		public Mountain(float height,  climbingOpportunities)
		{
			
			this.Height = height;
			
			this.ClimbingOpportunities = climbingOpportunities;
			
		}

	
	
 
	}
}	
       