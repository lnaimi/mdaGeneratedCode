
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Island : NaturalAtrraction
	{
	
		public float Size { get; set;}
	

	
		public Island()
		{
			// Needed by EF
		}
		
		public Island(float size)
		{
			
			this.Size = size;
			
		}

	
	
 
	}
}	
       