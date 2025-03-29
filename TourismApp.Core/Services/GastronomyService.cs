
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class GastronomyService : IGastronomyService
	{
		private readonly IGastronomyRepository _gastronomyRepository;
		
		public GastronomyService(IGastronomyRepository gastronomyRepository)
		{
			_gastronomyRepository = gastronomyRepository;
		}
	}
}	
       