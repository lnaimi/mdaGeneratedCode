
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class MountainService : IMountainService
	{
		private readonly IMountainRepository _mountainRepository;
		
		public MountainService(IMountainRepository mountainRepository)
		{
			_mountainRepository = mountainRepository;
		}
	}
}	
       