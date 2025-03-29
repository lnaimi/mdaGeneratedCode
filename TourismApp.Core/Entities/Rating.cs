
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Rating : BaseEntity, IAggregateRoot
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
       