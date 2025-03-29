
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class GuestHouseService : IGuestHouseService
	{
		private readonly IGuestHouseRepository _guestHouseRepository;
		
		public GuestHouseService(IGuestHouseRepository guestHouseRepository)
		{
			_guestHouseRepository = guestHouseRepository;
		}
	}
}	
       