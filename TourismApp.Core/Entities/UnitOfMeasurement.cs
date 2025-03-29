
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class UnitOfMeasurement
	{
	
		public String Id { get; set;}
		public String Name { get; set;}
		public String Code { get; set;}
	

	
		public UnitOfMeasurement()
		{
			// Needed by EF
		}
		
		public UnitOfMeasurement(String id, String name, String code)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Code = code;
			
		}

	
	
 
	}
}	
       