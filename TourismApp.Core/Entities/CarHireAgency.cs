
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class CarHireAgency : BaseEntity
	{
	
		public  RentalPolicies { get; set;}
	

	
		public CarHireAgency()
		{
			// Needed by EF
		}
		
		public CarHireAgency( rentalPolicies)
		{
			
			this.RentalPolicies = rentalPolicies;
			
		}

	
	
 
	}
}	
       