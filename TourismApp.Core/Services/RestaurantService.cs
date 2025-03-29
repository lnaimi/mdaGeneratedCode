
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class RestaurantService : IRestaurantService
	{
		private readonly IRestaurantRepository _restaurantRepository;
		
		public RestaurantService(IRestaurantRepository restaurantRepository)
		{
			_restaurantRepository = restaurantRepository;
		}
	}
}	
       