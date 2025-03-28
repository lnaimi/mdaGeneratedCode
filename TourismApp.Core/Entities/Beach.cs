
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Beach : NaturalAtrraction
	{
	
		public float Size { get; set;}
		public int WaterQuality { get; set;}
	

	
		public Beach()
		{
			// Needed by EF
		}
		
		public Beach(float size, int waterQuality)
		{
			
			this.Size = size;
			
			this.WaterQuality = waterQuality;
			
		}

	
	
 
	}
}	
       