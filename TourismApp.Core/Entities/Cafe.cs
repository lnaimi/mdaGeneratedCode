
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Cafe : BaseEntity
	{
	
		public  Menu { get; set;}
	

	
		public Cafe()
		{
			// Needed by EF
		}
		
		public Cafe( menu)
		{
			
			this.Menu = menu;
			
		}

	
	
 
	}
}	
       