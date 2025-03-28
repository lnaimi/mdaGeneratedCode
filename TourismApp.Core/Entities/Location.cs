
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Location : A_Object A_Object
	{
	
		public  Name { get; set;}
		public  Description { get; set;}
		public double Longitude { get; set;}
		public double Latitude { get; set;}
		public String WebSite { get; set;}
		public  Adress { get; set;}
	
		public Action? Action { get; set;}
	
    private Dictionary<Guid, Transport> lsTransport = new Dictionary<Guid, Transport>();
		public Dictionary<Guid, Transport> ListTransport
        	{
            		get { return lsTransport; }
            		set { lsTransport = value; }
        	}
	

	
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
       