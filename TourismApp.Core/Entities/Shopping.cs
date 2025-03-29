
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Shopping : BaseEntity
	{
	
		public  Type { get; set;}
	

	
		public Shopping()
		{
			// Needed by EF
		}
		
		public Shopping( type)
		{
			
			this.Type = type;
			
		}

	
	
 
	}
}	
       