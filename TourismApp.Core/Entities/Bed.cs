
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Bed
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
       