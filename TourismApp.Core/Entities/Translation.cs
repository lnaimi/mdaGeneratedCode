
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Translation
	{
	
		public String Id { get; set;}
		public String Value { get; set;}
		public  Language { get; set;}
	

	
		public Translation()
		{
			// Needed by EF
		}
		
		public Translation(String id, String value,  language)
		{
			
			this.Id = id;
			
			this.Value = value;
			
			this.Language = language;
			
		}

	
	
 
	}
}	
       