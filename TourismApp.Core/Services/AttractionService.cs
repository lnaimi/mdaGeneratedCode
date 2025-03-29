
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AttractionService : IAttractionService
	{
		private readonly IAttractionRepository _attractionRepository;
		
		public AttractionService(IAttractionRepository attractionRepository)
		{
			_attractionRepository = attractionRepository;
		}
	}
}	
       