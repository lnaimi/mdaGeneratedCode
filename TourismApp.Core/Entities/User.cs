
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTourismOntology (2).SharedKernel.Interfaces;
using SmartTourismOntology (2).SharedKernel;

namespace SmartTourismOntology (2).Core.Entities
{

public class User
	{
	
		public String Id { get; set;}
		public String FirstName { get; set;}
		public String LastName { get; set;}
		public String Email { get; set;}
		public Date DateOfBirth { get; set;}
		public String Phone { get; set;}
		public  Gender { get; set;}
	
    private Dictionary<Guid, UserAbility> lsUserAbility = new Dictionary<Guid, UserAbility>();
		public Dictionary<Guid, UserAbility> ListUserAbility
        	{
            		get { return lsUserAbility; }
            		set { lsUserAbility = value; }
        	}
	
    private Dictionary<Guid, UserInterest> lsUserInterest = new Dictionary<Guid, UserInterest>();
		public Dictionary<Guid, UserInterest> ListUserInterest
        	{
            		get { return lsUserInterest; }
            		set { lsUserInterest = value; }
        	}
	
    private Dictionary<Guid, UserPaymentOption> lsUserPaymentOption = new Dictionary<Guid, UserPaymentOption>();
		public Dictionary<Guid, UserPaymentOption> ListUserPaymentOption
        	{
            		get { return lsUserPaymentOption; }
            		set { lsUserPaymentOption = value; }
        	}
	
    private Dictionary<Guid, Language> lsLanguage = new Dictionary<Guid, Language>();
		public Dictionary<Guid, Language> ListLanguage
        	{
            		get { return lsLanguage; }
            		set { lsLanguage = value; }
        	}
	

	
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
       