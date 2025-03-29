
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Language
	{
	
		public String Id { get; set;}
		public String Name { get; set;}
		public String NativeName { get; set;}
		public String Code { get; set;}
	

	
		public Language()
		{
			// Needed by EF
		}
		
		public Language(String id, String name, String nativeName, String code)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.NativeName = nativeName;
			
			this.Code = code;
			
		}

	
	
 
	}
}	
       