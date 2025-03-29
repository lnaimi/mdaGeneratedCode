
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class LodgeService : ILodgeService
	{
		private readonly ILodgeRepository _lodgeRepository;
		
		public LodgeService(ILodgeRepository lodgeRepository)
		{
			_lodgeRepository = lodgeRepository;
		}
	}
}	
       