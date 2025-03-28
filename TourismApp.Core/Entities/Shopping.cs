
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Shopping : ArtificialAttraction
	{
	
		public  Type { get; set;}
	

	
		public Shopping()
		{
			// Needed by EF
		}
		
		public Shopping( type)
		{
			
			this.Type = type;
			
		}

	
	
 
	}
}	
       