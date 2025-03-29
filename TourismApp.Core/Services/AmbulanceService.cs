
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AmbulanceService : IAmbulanceService
	{
		private readonly IAmbulanceRepository _ambulanceRepository;
		
		public AmbulanceService(IAmbulanceRepository ambulanceRepository)
		{
			_ambulanceRepository = ambulanceRepository;
		}
	}
}	
       