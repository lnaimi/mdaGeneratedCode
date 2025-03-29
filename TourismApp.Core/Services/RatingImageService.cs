
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class RatingImageService : IRatingImageService
	{
		private readonly IRatingImageRepository _ratingImageRepository;
		
		public RatingImageService(IRatingImageRepository ratingImageRepository)
		{
			_ratingImageRepository = ratingImageRepository;
		}
	}
}	
       