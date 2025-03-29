
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Bed : BaseEntity
	{
	
		public String Id { get; set;}
		public Integer Quantity { get; set;}
	

	
		public Bed()
		{
			// Needed by EF
		}
		
		public Bed(String id, Integer quantity)
		{
			
			this.Id = id;
			
			this.Quantity = quantity;
			
		}

	
	
 
	}
}	
       