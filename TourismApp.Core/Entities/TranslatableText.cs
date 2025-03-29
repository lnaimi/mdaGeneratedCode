
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class TranslatableText
	{
	
		public String Id { get; set;}
		public String DefaultValue { get; set;}
	

	
		public TranslatableText()
		{
			// Needed by EF
		}
		
		public TranslatableText(String id, String defaultValue)
		{
			
			this.Id = id;
			
			this.DefaultValue = defaultValue;
			
		}

	
	
 
	}
}	
       