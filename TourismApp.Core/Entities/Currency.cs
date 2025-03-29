
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Currency
	{
	
		public String Id { get; set;}
		public String Name { get; set;}
		public String Symbol { get; set;}
		public String Code { get; set;}
		public String Image { get; set;}
	

	
		public Currency()
		{
			// Needed by EF
		}
		
		public Currency(String id, String name, String symbol, String code, String image)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Symbol = symbol;
			
			this.Code = code;
			
			this.Image = image;
			
		}

	
	
 
	}
}	
       