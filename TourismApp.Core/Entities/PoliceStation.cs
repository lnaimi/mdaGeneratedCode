
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class PoliceStation : BaseEntity
	{
	
		public String Type { get; set;}
	

	
		public PoliceStation()
		{
			// Needed by EF
		}
		
		public PoliceStation(String type)
		{
			
			this.Type = type;
			
		}

	
	
 
	}
}	
       