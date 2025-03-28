
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class LocationImage
	{
	
		public String Id { get; set;}
		public String ImageLink { get; set;}
		public  Title { get; set;}
	
		public Location Location { get; set;}
	

	
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
       