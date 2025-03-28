
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class RatingImage
	{
	
		public String Id { get; set;}
		public String ImageLink { get; set;}
		public  Title { get; set;}
	
		public Rating Rating { get; set;}
	

	
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
       