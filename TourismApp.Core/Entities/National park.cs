
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class National park : NaturalAtrraction
	{
	
		public int Area { get; set;}
	

	
		public National park()
		{
			// Needed by EF
		}
		
		public National park(int area)
		{
			
			this.Area = area;
			
		}

	
	
 
	}
}	
       