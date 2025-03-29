
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class TravelAgencyService : ITravelAgencyService
	{
		private readonly ITravelAgencyRepository _travelAgencyRepository;
		
		public TravelAgencyService(ITravelAgencyRepository travelAgencyRepository)
		{
			_travelAgencyRepository = travelAgencyRepository;
		}
	}
}	
       