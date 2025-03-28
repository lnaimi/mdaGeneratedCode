
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Room
	{
	
		public String Id { get; set;}
		public  Name { get; set;}
		public  Description { get; set;}
		public String RoomType { get; set;}
		public boolean Tv { get; set;}
		public boolean Wifi { get; set;}
		public boolean AirConditioner { get; set;}
		public Common Classes App.Pricing Price { get; set;}
	
    private Dictionary<Guid, Amenity> lsAmenity = new Dictionary<Guid, Amenity>();
		public Dictionary<Guid, Amenity> ListAmenity
        	{
            		get { return lsAmenity; }
            		set { lsAmenity = value; }
        	}
	
    private Dictionary<Guid, Bed> lsBed = new Dictionary<Guid, Bed>();
		public Dictionary<Guid, Bed> ListBed
        	{
            		get { return lsBed; }
            		set { lsBed = value; }
        	}
	

	
		public Room()
		{
			// Needed by EF
		}
		
		public Room(String id,  name,  description, String roomType, boolean tv, boolean wifi, boolean airConditioner, Common Classes App.Pricing price)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Description = description;
			
			this.RoomType = roomType;
			
			this.Tv = tv;
			
			this.Wifi = wifi;
			
			this.AirConditioner = airConditioner;
			
			this.Price = price;
			
		}

	
	
 
	}
}	
       