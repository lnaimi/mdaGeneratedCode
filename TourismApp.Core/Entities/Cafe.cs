
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Cafe : Gastronomy
	{
	
		public  Menu { get; set;}
	

	
		public Cafe()
		{
			// Needed by EF
		}
		
		public Cafe( menu)
		{
			
			this.Menu = menu;
			
		}

	
	
 
	}
}	
       