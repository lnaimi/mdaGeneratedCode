
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class AmenityFeature
	{
	
		public String Id { get; set;}
		public  Name { get; set;}
		public  Description { get; set;}
		public int Value { get; set;}
		public DateTime ValidFrom { get; set;}
		public DateTime ValidThrough { get; set;}
	
    private Dictionary<Guid, Amenity> lsAmenity = new Dictionary<Guid, Amenity>();
		public Dictionary<Guid, Amenity> ListAmenity
        	{
            		get { return lsAmenity; }
            		set { lsAmenity = value; }
        	}
	

	
		public AmenityFeature()
		{
			// Needed by EF
		}
		
		public AmenityFeature(String id,  name,  description, int value, DateTime validFrom, DateTime validThrough)
		{
			
			this.Id = id;
			
			this.Name = name;
			
			this.Description = description;
			
			this.Value = value;
			
			this.ValidFrom = validFrom;
			
			this.ValidThrough = validThrough;
			
		}

	
	
 
	}
}	
       