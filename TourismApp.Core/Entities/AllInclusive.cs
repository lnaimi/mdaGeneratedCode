
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class AllInclusive : AmenityService
	{
	
		public  Restrictions { get; set;}
	

	
		public AllInclusive()
		{
			// Needed by EF
		}
		
		public AllInclusive( restrictions)
		{
			
			this.Restrictions = restrictions;
			
		}

	
	
 
	}
}	
       