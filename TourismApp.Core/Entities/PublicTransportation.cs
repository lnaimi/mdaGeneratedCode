
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class PublicTransportation : BaseEntity
	{
	
		public  Name { get; set;}
		public  Description { get; set;}
		public String Society { get; set;}
		public String PhoneNumber { get; set;}
		public String WebSite { get; set;}
		public float RentalCost { get; set;}
	

	
		public PublicTransportation()
		{
			// Needed by EF
		}
		
		public PublicTransportation( name,  description, String society, String phoneNumber, String webSite, float rentalCost)
		{
			
			this.Name = name;
			
			this.Description = description;
			
			this.Society = society;
			
			this.PhoneNumber = phoneNumber;
			
			this.WebSite = webSite;
			
			this.RentalCost = rentalCost;
			
		}

	
	
 
	}
}	
       