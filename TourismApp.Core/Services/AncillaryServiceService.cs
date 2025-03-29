
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AncillaryServiceService : IAncillaryServiceService
	{
		private readonly IAncillaryServiceRepository _ancillaryServiceRepository;
		
		public AncillaryServiceService(IAncillaryServiceRepository ancillaryServiceRepository)
		{
			_ancillaryServiceRepository = ancillaryServiceRepository;
		}
	}
}	
       