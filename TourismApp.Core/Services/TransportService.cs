
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class TransportService : ITransportService
	{
		private readonly ITransportRepository _transportRepository;
		
		public TransportService(ITransportRepository transportRepository)
		{
			_transportRepository = transportRepository;
		}
	}
}	
       