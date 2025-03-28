
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Question : Action
	{
	
		public  Text { get; set;}
	

	
		public Question()
		{
			// Needed by EF
		}
		
		public Question( text)
		{
			
			this.Text = text;
			
		}

	
	
 
	}
}	
       