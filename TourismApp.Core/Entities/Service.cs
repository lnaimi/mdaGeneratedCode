
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

      []
    
public class Service : BaseEntity, 
	{
	
		public  Name { get; set;}
		public  Description { get; set;}
		public  Adress { get; set;}
		public String PhoneNumber { get; set;}
		public Time OpeningTime { get; set;}
		public Time ClosingTime { get; set;}
		public double Latitude { get; set;}
		public double Longitude { get; set;}
	

	
		public Service()
		{
			// Needed by EF
		}
		
		public Service( name,  description,  adress, String phoneNumber, Time openingTime, Time closingTime, double latitude, double longitude)
		{
			
			this.Name = name;
			
			this.Description = description;
			
			this.Adress = adress;
			
			this.PhoneNumber = phoneNumber;
			
			this.OpeningTime = openingTime;
			
			this.ClosingTime = closingTime;
			
			this.Latitude = latitude;
			
			this.Longitude = longitude;
			
		}

	
	
 
	}
}	
       