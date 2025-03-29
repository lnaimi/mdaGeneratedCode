
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class LocationService : ILocationService
	{
		private readonly ILocationRepository _locationRepository;
		
		public LocationService(ILocationRepository locationRepository)
		{
			_locationRepository = locationRepository;
		}
	}
}	
       