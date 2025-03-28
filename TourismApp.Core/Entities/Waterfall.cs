
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Waterfall : NaturalAtrraction
	{
	
		public float Height { get; set;}
		public float Volume { get; set;}
	

	
		public Waterfall()
		{
			// Needed by EF
		}
		
		public Waterfall(float height, float volume)
		{
			
			this.Height = height;
			
			this.Volume = volume;
			
		}

	
	
 
	}
}	
       