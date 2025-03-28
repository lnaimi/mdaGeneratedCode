
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Hill : NaturalAtrraction
	{
	
		public float Height { get; set;}
	

	
		public Hill()
		{
			// Needed by EF
		}
		
		public Hill(float height)
		{
			
			this.Height = height;
			
		}

	
	
 
	}
}	
       