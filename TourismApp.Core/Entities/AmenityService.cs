
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class AmenityService
	{
	
		public String Id { get; set;}
		public  Name { get; set;}
		public  Description { get; set;}
		public Common Classes App.Pricing Price { get; set;}
	

	
		public AmenityService()
		{
			// Needed by EF
		}
		
		public AmenityService(String id,  name,  description, Common Classes App.Pricing price)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Description = description;
			
			this.Price = price;
			
		}

	
	
 
	}
}	
       