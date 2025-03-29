
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class National park
	{
	
		public int Area { get; set;}
	

	
		public National park()
		{
			// Needed by EF
		}
		
		public National park(int area)
		{
			
			this.Area = area;
			
		}

	
	
 
	}
}	
       