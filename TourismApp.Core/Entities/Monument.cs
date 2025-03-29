
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Monument : BaseEntity
	{
	
		public  MonumentHistory { get; set;}
	

	
		public Monument()
		{
			// Needed by EF
		}
		
		public Monument( monumentHistory)
		{
			
			this.MonumentHistory = monumentHistory;
			
		}

	
	
 
	}
}	
       