
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class LikeActionService : ILikeActionService
	{
		private readonly ILikeActionRepository _likeActionRepository;
		
		public LikeActionService(ILikeActionRepository likeActionRepository)
		{
			_likeActionRepository = likeActionRepository;
		}
	}
}	
       