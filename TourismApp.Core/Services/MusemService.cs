
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class MusemService : IMusemService
	{
		private readonly IMusemRepository _musemRepository;
		
		public MusemService(IMusemRepository musemRepository)
		{
			_musemRepository = musemRepository;
		}
	}
}	
       