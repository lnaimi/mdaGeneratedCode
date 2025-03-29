
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ReligionAttractionService : IReligionAttractionService
	{
		private readonly IReligionAttractionRepository _religionAttractionRepository;
		
		public ReligionAttractionService(IReligionAttractionRepository religionAttractionRepository)
		{
			_religionAttractionRepository = religionAttractionRepository;
		}
	}
}	
       