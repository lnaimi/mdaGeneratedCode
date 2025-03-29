
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class AddressType
	{
	
		public String Id { get; set;}
		public String Type { get; set;}
		public String Description { get; set;}
	

	
		public AddressType()
		{
			// Needed by EF
		}
		
		public AddressType(String id, String type, String description)
		{
			
			this.Id = id;
			
			this.Type = type;
			
			this.Description = description;
			
		}

	
	
 
	}
}	
       