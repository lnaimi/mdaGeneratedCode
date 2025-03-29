
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Answer : BaseEntity
	{
	
		public  Text { get; set;}
	

	
		public Answer()
		{
			// Needed by EF
		}
		
		public Answer( text)
		{
			
			this.Text = text;
			
		}

	
	
 
	}
}	
       