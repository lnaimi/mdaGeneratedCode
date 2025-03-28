
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class ArchitecturalAttraction : ArtificialAttraction
	{
	
		public  ArchitecturalAttractionHistory { get; set;}
	

	
		public ArchitecturalAttraction()
		{
			// Needed by EF
		}
		
		public ArchitecturalAttraction( architecturalAttractionHistory)
		{
			
			this.ArchitecturalAttractionHistory = architecturalAttractionHistory;
			
		}

	
	
 
	}
}	
       