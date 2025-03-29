
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Forest : BaseEntity
	{
	
		public  Type { get; set;}
	

	
		public Forest()
		{
			// Needed by EF
		}
		
		public Forest( type)
		{
			
			this.Type = type;
			
		}

	
	
 
	}
}	
       