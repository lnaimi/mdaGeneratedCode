
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class NaturalAtrractionService : INaturalAtrractionService
	{
		private readonly INaturalAtrractionRepository _naturalAtrractionRepository;
		
		public NaturalAtrractionService(INaturalAtrractionRepository naturalAtrractionRepository)
		{
			_naturalAtrractionRepository = naturalAtrractionRepository;
		}
	}
}	
       