
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

public class Account : BaseEntity, IAggregateRoot
	{
	
		public String Id { get; set;}
		public String Login { get; set;}
		public String PassWord { get; set;}
	

	
		public Account()
		{
			// Needed by EF
		}
		
		public Account(String id, String login, String passWord)
		{
			
			this.Id = id;
			
			this.Login = login;
			
			this.PassWord = passWord;
			
		}

	
	
 
	}
}	
       