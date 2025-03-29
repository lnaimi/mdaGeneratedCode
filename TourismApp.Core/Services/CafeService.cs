
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class CafeService : ICafeService
	{
		private readonly ICafeRepository _cafeRepository;
		
		public CafeService(ICafeRepository cafeRepository)
		{
			_cafeRepository = cafeRepository;
		}
	}
}	
       