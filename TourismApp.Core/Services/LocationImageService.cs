
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class LocationImageService : ILocationImageService
	{
		private readonly ILocationImageRepository _locationImageRepository;
		
		public LocationImageService(ILocationImageRepository locationImageRepository)
		{
			_locationImageRepository = locationImageRepository;
		}
	}
}	
       