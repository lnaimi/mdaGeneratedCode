
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Monument : HistoricalAttraction
	{
	
		public  MonumentHistory { get; set;}
	

	
		public Monument()
		{
			// Needed by EF
		}
		
		public Monument( monumentHistory)
		{
			
			this.MonumentHistory = monumentHistory;
			
		}

	
	
 
	}
}	
       