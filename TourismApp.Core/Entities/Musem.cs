
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Musem : HistoricalAttraction
	{
	
		public int NumberOfExhibits { get; set;}
	

	
		public Musem()
		{
			// Needed by EF
		}
		
		public Musem(int numberOfExhibits)
		{
			
			this.NumberOfExhibits = numberOfExhibits;
			
		}

	
	
 
	}
}	
       