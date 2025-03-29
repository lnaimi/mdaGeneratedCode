
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class LocationImage : BaseEntity
	{
	
		public String Id { get; set;}
		public String ImageLink { get; set;}
		public  Title { get; set;}
	

	
		public LocationImage()
		{
			// Needed by EF
		}
		
		public LocationImage(String id, String imageLink,  title)
		{
			
			this.Id = id;
			
			this.ImageLink = imageLink;
			
			this.Title = title;
			
		}

	
	
 
	}
}	
       