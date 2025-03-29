
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class TourGuideService : ITourGuideService
	{
		private readonly ITourGuideRepository _tourGuideRepository;
		
		public TourGuideService(ITourGuideRepository tourGuideRepository)
		{
			_tourGuideRepository = tourGuideRepository;
		}
	}
}	
       