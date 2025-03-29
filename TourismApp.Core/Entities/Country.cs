
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Country
	{
	
		public String Id { get; set;}
		public String Name { get; set;}
		public  DisplayName { get; set;}
		public String ThreeLetterCode { get; set;}
		public String TwoLetterCode { get; set;}
		public  ShortName { get; set;}
	

	
		public Country()
		{
			// Needed by EF
		}
		
		public Country(String id, String name,  displayName, String threeLetterCode, String twoLetterCode,  shortName)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.DisplayName = displayName;
			
			this.ThreeLetterCode = threeLetterCode;
			
			this.TwoLetterCode = twoLetterCode;
			
			this.ShortName = shortName;
			
		}

	
	
 
	}
}	
       