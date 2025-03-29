
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class UserAddressService : IUserAddressService
	{
		private readonly IUserAddressRepository _userAddressRepository;
		
		public UserAddressService(IUserAddressRepository userAddressRepository)
		{
			_userAddressRepository = userAddressRepository;
		}
	}
}	
       