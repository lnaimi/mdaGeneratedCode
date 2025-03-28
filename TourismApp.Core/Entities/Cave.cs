
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Cave : NaturalAtrraction
	{
	
		public float Length { get; set;}
		public float Width { get; set;}
	

	
		public Cave()
		{
			// Needed by EF
		}
		
		public Cave(float length, float width)
		{
			
			this.Length = length;
			
			this.Width = width;
			
		}

	
	
 
	}
}	
       