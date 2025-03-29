
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Adress
	{
	
		public String Id { get; set;}
		public string LineAdress1 { get; set;}
		public string LineAdress2 { get; set;}
		public Common Classes. App.City City { get; set;}
		public  Country { get; set;}
		public int ZipCode { get; set;}
	

	
		public Adress()
		{
			// Needed by EF
		}
		
		public Adress(String id, string lineAdress1, string lineAdress2, Common Classes. App.City city,  country, int zipCode)
		{
			
			this.Id = id;
			
			this.LineAdress1 = lineAdress1;
			
			this.LineAdress2 = lineAdress2;
			
			this.City = city;
			
			this.Country = country;
			
			this.ZipCode = zipCode;
			
		}

	
	
 
	}
}	
       