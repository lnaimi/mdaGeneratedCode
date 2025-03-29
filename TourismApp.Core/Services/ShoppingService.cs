
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ShoppingService : IShoppingService
	{
		private readonly IShoppingRepository _shoppingRepository;
		
		public ShoppingService(IShoppingRepository shoppingRepository)
		{
			_shoppingRepository = shoppingRepository;
		}
	}
}	
       