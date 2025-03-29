
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class RatingImage : BaseEntity
	{
	
		public String Id { get; set;}
		public String ImageLink { get; set;}
		public  Title { get; set;}
	

	
		public RatingImage()
		{
			// Needed by EF
		}
		
		public RatingImage(String id, String imageLink,  title)
		{
			
			this.Id = id;
			
			this.ImageLink = imageLink;
			
			this.Title = title;
			
		}

	
	
 
	}
}	
       