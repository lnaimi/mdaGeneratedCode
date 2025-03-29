
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class BedService : IBedService
	{
		private readonly IBedRepository _bedRepository;
		
		public BedService(IBedRepository bedRepository)
		{
			_bedRepository = bedRepository;
		}
	}
}	
       