
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class City
	{
	
		public String Id { get; set;}
		public String Name { get; set;}
		public String Latitude { get; set;}
		public String Longitude { get; set;}
	

	
		public City()
		{
			// Needed by EF
		}
		
		public City(String id, String name, String latitude, String longitude)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Latitude = latitude;
			
			this.Longitude = longitude;
			
		}

	
	
 
	}
}	
       