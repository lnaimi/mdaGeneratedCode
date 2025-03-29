
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ForestService : IForestService
	{
		private readonly IForestRepository _forestRepository;
		
		public ForestService(IForestRepository forestRepository)
		{
			_forestRepository = forestRepository;
		}
	}
}	
       