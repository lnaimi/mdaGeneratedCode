
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Room : BaseEntity, IAggregateRoot
	{
	
		public String Id { get; set;}
		public  Name { get; set;}
		public  Description { get; set;}
		public String RoomType { get; set;}
		public boolean Tv { get; set;}
		public boolean Wifi { get; set;}
		public boolean AirConditioner { get; set;}
		public Common Classes App.Pricing Price { get; set;}
	

	
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
       