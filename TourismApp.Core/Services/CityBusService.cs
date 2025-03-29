
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class CityBusService : ICityBusService
	{
		private readonly ICityBusRepository _cityBusRepository;
		
		public CityBusService(ICityBusRepository cityBusRepository)
		{
			_cityBusRepository = cityBusRepository;
		}
	}
}	
       