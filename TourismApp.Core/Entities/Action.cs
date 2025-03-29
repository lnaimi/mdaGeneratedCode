
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

      []
    
public class Action : BaseEntity, , IAggregateRoot
	{
	
		public String Id { get; set;}
		public DateTime Date { get; set;}
	

	
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
       