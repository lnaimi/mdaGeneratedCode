
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class HistoricalAttractionService : IHistoricalAttractionService
	{
		private readonly IHistoricalAttractionRepository _historicalAttractionRepository;
		
		public HistoricalAttractionService(IHistoricalAttractionRepository historicalAttractionRepository)
		{
			_historicalAttractionRepository = historicalAttractionRepository;
		}
	}
}	
       