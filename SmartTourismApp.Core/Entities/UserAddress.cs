

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class UserAddress : BaseEntity {


            public string LineAdress1 { get;  set; }

            public string LineAdress2 { get;  set; }

            public City City { get;  set; }

            public string PostalCode { get;  set; }

            public AddressType AdresseType { get;  set; }

            public string State { get;  set; }

            public int UserId { get;  set; }

            public User User { get;  set; }

            public UserAddress() { }
            
        }

    }
        