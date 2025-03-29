
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class MealService : IMealService
	{
		private readonly IMealRepository _mealRepository;
		
		public MealService(IMealRepository mealRepository)
		{
			_mealRepository = mealRepository;
		}
	}
}	
       