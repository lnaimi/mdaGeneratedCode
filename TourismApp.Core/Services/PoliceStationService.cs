
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class PoliceStationService : IPoliceStationService
	{
		private readonly IPoliceStationRepository _policeStationRepository;
		
		public PoliceStationService(IPoliceStationRepository policeStationRepository)
		{
			_policeStationRepository = policeStationRepository;
		}
	}
}	
       