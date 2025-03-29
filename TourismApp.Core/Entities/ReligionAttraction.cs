
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class ReligionAttraction : BaseEntity
	{
	
		public String Id { get; set;}
		public  Name { get; set;}
		public  Religion { get; set;}
	

	
		public ReligionAttraction()
		{
			// Needed by EF
		}
		
		public ReligionAttraction(String id,  name,  religion)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Religion = religion;
			
		}

	
	
 
	}
}	
       