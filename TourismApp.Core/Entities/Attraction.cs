
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

      []
    
public class Attraction : BaseEntity, IAggregateRoot, 
	{
	
		public bool IsFreeAccess { get; set;}
		public Bool IsKidsAllowed { get; set;}
		public  EntranceFee { get; set;}
		public DateTime SuggestedDuration { get; set;}
		public  SuggestedPeriod { get; set;}
		public  Instructions { get; set;}
	

	
		public Attraction()
		{
			// Needed by EF
		}
		
		public Attraction(bool isFreeAccess, Bool isKidsAllowed,  entranceFee, DateTime suggestedDuration,  suggestedPeriod,  instructions)
		{
			
			this.IsFreeAccess = isFreeAccess;
			
			this.IsKidsAllowed = isKidsAllowed;
			
			this.EntranceFee = entranceFee;
			
			this.SuggestedDuration = suggestedDuration;
			
			this.SuggestedPeriod = suggestedPeriod;
			
			this.Instructions = instructions;
			
		}

	
	
 
	}
}	
       