
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class UserAddress : BaseEntity, IAggregateRoot
	{
	
		public String Id { get; set;}
		public String LineAdress1 { get; set;}
		public String LineAdress2 { get; set;}
		public Common Classes. App.City City { get; set;}
		public  Country { get; set;}
		public String ZipCode { get; set;}
		public  AdresseType { get; set;}
		public String State { get; set;}
	

	
		public UserAddress()
		{
			// Needed by EF
		}
		
		public UserAddress(String id, String lineAdress1, String lineAdress2, Common Classes. App.City city,  country, String zipCode,  adresseType, String state)
		{
			
			this.Id = id;
			
			this.LineAdress1 = lineAdress1;
			
			this.LineAdress2 = lineAdress2;
			
			this.City = city;
			
			this.Country = country;
			
			this.ZipCode = zipCode;
			
			this.AdresseType = adresseType;
			
			this.State = state;
			
		}

	
	
 
	}
}	
       