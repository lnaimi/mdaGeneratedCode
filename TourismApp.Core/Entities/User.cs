
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismApp.SharedKernel.Interfaces;
using TourismApp.SharedKernel;

namespace TourismApp.Core.Entities
{

      []
    
public class User : BaseEntity, , IAggregateRoot
	{
	
		public String Id { get; set;}
		public String FirstName { get; set;}
		public String LastName { get; set;}
		public String Email { get; set;}
		public Date DateOfBirth { get; set;}
		public String Phone { get; set;}
		public  Gender { get; set;}
	

	
		public User()
		{
			// Needed by EF
		}
		
		public User(String id, String firstName, String lastName, String email, Date dateOfBirth, String phone,  gender)
		{
			
			this.Id = id;
			
			this.FirstName = firstName;
			
			this.LastName = lastName;
			
			this.Email = email;
			
			this.DateOfBirth = dateOfBirth;
			
			this.Phone = phone;
			
			this.Gender = gender;
			
		}

	
	
 
	}
}	
       