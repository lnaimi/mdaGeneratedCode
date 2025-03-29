
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class AllInclusive : BaseEntity
	{
	
		public  Restrictions { get; set;}
	

	
		public AllInclusive()
		{
			// Needed by EF
		}
		
		public AllInclusive( restrictions)
		{
			
			this.Restrictions = restrictions;
			
		}

	
	
 
	}
}	
       