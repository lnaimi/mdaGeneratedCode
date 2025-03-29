
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AmenityService : IAmenityService
	{
		private readonly IAmenityRepository _amenityRepository;
		
		public AmenityService(IAmenityRepository amenityRepository)
		{
			_amenityRepository = amenityRepository;
		}
	}
}	
       