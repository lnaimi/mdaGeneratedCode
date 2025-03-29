
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class CarHireAgencyService : ICarHireAgencyService
	{
		private readonly ICarHireAgencyRepository _carHireAgencyRepository;
		
		public CarHireAgencyService(ICarHireAgencyRepository carHireAgencyRepository)
		{
			_carHireAgencyRepository = carHireAgencyRepository;
		}
	}
}	
       