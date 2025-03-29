
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class CampingaService : ICampingaService
	{
		private readonly ICampingaRepository _campingaRepository;
		
		public CampingaService(ICampingaRepository campingaRepository)
		{
			_campingaRepository = campingaRepository;
		}
	}
}	
       