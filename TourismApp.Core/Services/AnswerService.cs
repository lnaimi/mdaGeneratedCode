
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourismApp.Core.Interfaces;
using TourismApp.Core.Specifications;

namespace TourismApp.Core.Services
{
	public class AnswerService : IAnswerService
	{
		private readonly IAnswerRepository _answerRepository;
		
		public AnswerService(IAnswerRepository answerRepository)
		{
			_answerRepository = answerRepository;
		}
	}
}	
       