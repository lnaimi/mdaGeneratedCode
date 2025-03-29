
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AllInclusiveService : IAllInclusiveService
	{
		private readonly IAllInclusiveRepository _allInclusiveRepository;
		
		public AllInclusiveService(IAllInclusiveRepository allInclusiveRepository)
		{
			_allInclusiveRepository = allInclusiveRepository;
		}
	}
}	
       