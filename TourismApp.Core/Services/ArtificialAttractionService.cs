
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ArtificialAttractionService : IArtificialAttractionService
	{
		private readonly IArtificialAttractionRepository _artificialAttractionRepository;
		
		public ArtificialAttractionService(IArtificialAttractionRepository artificialAttractionRepository)
		{
			_artificialAttractionRepository = artificialAttractionRepository;
		}
	}
}	
       