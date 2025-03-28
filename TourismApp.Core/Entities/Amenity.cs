
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Amenity : Location
	{
	
		public String Phone { get; set;}
		public Float Discount { get; set;}
		public float Occupancy { get; set;}
		public String Mail { get; set;}
	
		public Amenity Amenity { get; set;}
	
		public Amenity Amenity { get; set;}
	

	
		public Amenity()
		{
			// Needed by EF
		}
		
		public Amenity(String phone, Float discount, float occupancy, String mail)
		{
			
			this.Phone = phone;
			
			this.Discount = discount;
			
			this.Occupancy = occupancy;
			
			this.Mail = mail;
			
		}

	
	
 
	}
}	
       