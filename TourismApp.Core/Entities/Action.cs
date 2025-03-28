
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Action
	{
	
		public String Id { get; set;}
		public DateTime Date { get; set;}
	
		public Account Account { get; set;}
	
		public A_Object? A_Object { get; set;}
	

	
		public Action()
		{
			// Needed by EF
		}
		
		public Action(String id, DateTime date)
		{
			
			this.Id = id;
			
			this.Date = date;
			
		}

	
	
 
	}
}	
       