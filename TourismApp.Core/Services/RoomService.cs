
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class RoomService : IRoomService
	{
		private readonly IRoomRepository _roomRepository;
		
		public RoomService(IRoomRepository roomRepository)
		{
			_roomRepository = roomRepository;
		}
	}
}	
       