
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Cliff : NaturalAtrraction
	{
	
		public float Height { get; set;}
		public float Width { get; set;}
	

	
		public Cliff()
		{
			// Needed by EF
		}
		
		public Cliff(float height, float width)
		{
			
			this.Height = height;
			
			this.Width = width;
			
		}

	
	
 
	}
}	
       