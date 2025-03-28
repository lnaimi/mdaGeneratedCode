
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class UserInterest
	{
	
		public String Id { get; set;}
		public  Interest { get; set;}
		public String Level { get; set;}
	

	
		public UserInterest()
		{
			// Needed by EF
		}
		
		public UserInterest(String id,  interest, String level)
		{
			
			this.Id = id;
			
			this.Interest = interest;
			
			this.Level = level;
			
		}

	
	
 
	}
}	
       