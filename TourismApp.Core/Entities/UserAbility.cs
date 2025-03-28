
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class UserAbility
	{
	
		public String Id { get; set;}
		public  Ability { get; set;}
		public String Level { get; set;}
	

	
		public UserAbility()
		{
			// Needed by EF
		}
		
		public UserAbility(String id,  ability, String level)
		{
			
			this.Id = id;
			
			this.Ability = ability;
			
			this.Level = level;
			
		}

	
	
 
	}
}	
       