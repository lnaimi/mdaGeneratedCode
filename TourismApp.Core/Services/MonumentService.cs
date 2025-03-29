
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class MonumentService : IMonumentService
	{
		private readonly IMonumentRepository _monumentRepository;
		
		public MonumentService(IMonumentRepository monumentRepository)
		{
			_monumentRepository = monumentRepository;
		}
	}
}	
       