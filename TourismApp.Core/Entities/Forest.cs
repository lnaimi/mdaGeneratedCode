
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Forest : NaturalAtrraction
	{
	
		public  Type { get; set;}
	

	
		public Forest()
		{
			// Needed by EF
		}
		
		public Forest( type)
		{
			
			this.Type = type;
			
		}

	
	
 
	}
}	
       