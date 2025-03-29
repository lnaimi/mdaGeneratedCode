
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Ambulance : BaseEntity
	{
	
		public int PatientTransportCapacity { get; set;}
	

	
		public Ambulance()
		{
			// Needed by EF
		}
		
		public Ambulance(int patientTransportCapacity)
		{
			
			this.PatientTransportCapacity = patientTransportCapacity;
			
		}

	
	
 
	}
}	
       