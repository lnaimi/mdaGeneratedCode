
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class TaxiService : ITaxiService
	{
		private readonly ITaxiRepository _taxiRepository;
		
		public TaxiService(ITaxiRepository taxiRepository)
		{
			_taxiRepository = taxiRepository;
		}
	}
}	
       