
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Location2
	{
	
		public String Id { get; set;}
		public String Name { get; set;}
		public String Description { get; set;}
		public boolean PetsAllowed { get; set;}
		public double Longitude { get; set;}
		public double Latitude { get; set;}
		public String WebSite { get; set;}
		public String Badge { get; set;}
		public  Adress { get; set;}
	

	
		public Location2()
		{
			// Needed by EF
		}
		
		public Location2(String id, String name, String description, boolean petsAllowed, double longitude, double latitude, String webSite, String badge,  adress)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Description = description;
			
			this.PetsAllowed = petsAllowed;
			
			this.Longitude = longitude;
			
			this.Latitude = latitude;
			
			this.WebSite = webSite;
			
			this.Badge = badge;
			
			this.Adress = adress;
			
		}

	
	
 
	}
}	
       