
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class A_Object
	{
	
		public String Id { get; set;}
	

	
		public A_Object()
		{
			// Needed by EF
		}
		
		public A_Object(String id)
		{
			
			this.Id = id;
			
		}

	
	
 
	}
}	
       