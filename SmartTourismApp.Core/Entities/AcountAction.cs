

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
        
        public class AcountAction : BaseEntity, IAggregateRoot {


            public DateTimeOffset Date { get;  set; }

            public int AccountId { get;  set; }

            public Account Account { get;  set; }

            public List<Location> Locations { get;  set; } = new  List<Location>();

            public AcountAction() { }
            
        }

    }
        