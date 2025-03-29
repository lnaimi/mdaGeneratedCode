
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Bank : BaseEntity
	{
	
		public  Products { get; set;}
	

	
		public Bank()
		{
			// Needed by EF
		}
		
		public Bank( products)
		{
			
			this.Products = products;
			
		}

	
	
 
	}
}	
       