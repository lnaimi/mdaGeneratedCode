
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class Account
	{
	
		public String Id { get; set;}
		public String Login { get; set;}
		public String PassWord { get; set;}
	
		public User User { get; set;}
	
		public Visit? Visit { get; set;}
	

	
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
       