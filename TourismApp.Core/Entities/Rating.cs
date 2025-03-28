
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Rating : Action
	{
	
		public double Value { get; set;}
		public DateTime DateOfVisit { get; set;}
		public  Text { get; set;}
	

	
		public Rating()
		{
			// Needed by EF
		}
		
		public Rating(double value, DateTime dateOfVisit,  text)
		{
			
			this.Value = value;
			
			this.DateOfVisit = dateOfVisit;
			
			this.Text = text;
			
		}

	
	
 
	}
}	
       