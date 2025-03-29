

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel.Interfaces;
    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class User : BaseEntity, IAggregateRoot {


            public string FirstName { get;  set; }

            public string LastName { get;  set; }

            public string Email { get;  set; }

            public DateTimeOffset DateOfBirth { get;  set; }

            public string Phone { get;  set; }

            public Gender Gender { get;  set; }

            public List<UserAddress> UserAddresss { get;  set; } = new  List<UserAddress>();

            public List<Language> Languages { get;  set; } = new  List<Language>();

            public List<Account> Accounts { get;  set; } = new  List<Account>();

            public User() { }
            
        }

    }
        