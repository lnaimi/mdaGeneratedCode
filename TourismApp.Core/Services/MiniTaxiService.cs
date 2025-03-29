
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class MiniTaxiService : IMiniTaxiService
	{
		private readonly IMiniTaxiRepository _miniTaxiRepository;
		
		public MiniTaxiService(IMiniTaxiRepository miniTaxiRepository)
		{
			_miniTaxiRepository = miniTaxiRepository;
		}
	}
}	
       