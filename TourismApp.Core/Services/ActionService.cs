
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ActionService : IActionService
	{
		private readonly IActionRepository _actionRepository;
		
		public ActionService(IActionRepository actionRepository)
		{
			_actionRepository = actionRepository;
		}
	}
}	
       