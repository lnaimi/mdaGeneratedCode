
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Location : BaseEntity
	{
	
		public  Name { get; set;}
		public  Description { get; set;}
		public double Longitude { get; set;}
		public double Latitude { get; set;}
		public String WebSite { get; set;}
		public  Adress { get; set;}
	

	
		public Location()
		{
			// Needed by EF
		}
		
		public Location( name,  description, double longitude, double latitude, String webSite,  adress)
		{
			
			this.Name = name;
			
			this.Description = description;
			
			this.Longitude = longitude;
			
			this.Latitude = latitude;
			
			this.WebSite = webSite;
			
			this.Adress = adress;
			
		}

	
	
 
	}
}	
       