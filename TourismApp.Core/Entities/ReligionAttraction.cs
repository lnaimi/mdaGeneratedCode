
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class ReligionAttraction : ArtificialAttraction
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
       