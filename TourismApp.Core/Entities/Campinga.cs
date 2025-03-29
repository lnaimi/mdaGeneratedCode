
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Campinga : BaseEntity, IAggregateRoot
	{
	
		public boolean Gated { get; set;}
	

	
		public Campinga()
		{
			// Needed by EF
		}
		
		public Campinga(boolean gated)
		{
			
			this.Gated = gated;
			
		}

	
	
 
	}
}	
       