
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class BusService : IBusService
	{
		private readonly IBusRepository _busRepository;
		
		public BusService(IBusRepository busRepository)
		{
			_busRepository = busRepository;
		}
	}
}	
       