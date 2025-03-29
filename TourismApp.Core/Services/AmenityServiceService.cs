
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AmenityServiceService : IAmenityServiceService
	{
		private readonly IAmenityServiceRepository _amenityServiceRepository;
		
		public AmenityServiceService(IAmenityServiceRepository amenityServiceRepository)
		{
			_amenityServiceRepository = amenityServiceRepository;
		}
	}
}	
       