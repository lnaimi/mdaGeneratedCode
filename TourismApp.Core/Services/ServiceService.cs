
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ServiceService : IServiceService
	{
		private readonly IServiceRepository _serviceRepository;
		
		public ServiceService(IServiceRepository serviceRepository)
		{
			_serviceRepository = serviceRepository;
		}
	}
}	
       