
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Taxi : BaseEntity, IAggregateRoot
	{
	
		public  DepartureCity { get; set;}
		public  ArrivalCity { get; set;}
		public int NumberOfSeats { get; set;}
	

	
		public Taxi()
		{
			// Needed by EF
		}
		
		public Taxi( departureCity,  arrivalCity, int numberOfSeats)
		{
			
			this.DepartureCity = departureCity;
			
			this.ArrivalCity = arrivalCity;
			
			this.NumberOfSeats = numberOfSeats;
			
		}

	
	
 
	}
}	
       