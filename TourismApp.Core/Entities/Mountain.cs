
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Mountain : NaturalAtrraction
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
       