
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class ShareActionService : IShareActionService
	{
		private readonly IShareActionRepository _shareActionRepository;
		
		public ShareActionService(IShareActionRepository shareActionRepository)
		{
			_shareActionRepository = shareActionRepository;
		}
	}
}	
       