
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Answer : Action
	{
	
		public  Text { get; set;}
	
		public Question Question { get; set;}
	

	
		public Answer()
		{
			// Needed by EF
		}
		
		public Answer( text)
		{
			
			this.Text = text;
			
		}

	
	
 
	}
}	
       