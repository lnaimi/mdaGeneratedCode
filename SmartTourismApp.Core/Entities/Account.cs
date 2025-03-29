

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
        
        public class Account : BaseEntity, IAggregateRoot {


            public string Login { get;  set; }

            public string PassWord { get;  set; }

            public int UserId { get;  set; }

            public User User { get;  set; }

            public List<AcountAction> AcountActions { get;  set; } = new  List<AcountAction>();

            public Account() { }
            
        }

    }
        