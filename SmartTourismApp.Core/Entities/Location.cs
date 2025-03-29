

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
        
        public class Location : BaseEntity, IAggregateRoot {


            public TranslatableText Name { get;  set; }

            public TranslatableText Description { get;  set; }

            public double Longitude { get;  set; }

            public double Latitude { get;  set; }

            public string WebSite { get;  set; }

            public UserAddress Adress { get;  set; }

            public int?  AcountActionId { get;  set; }

            public AcountAction AcountAction { get;  set; }

            public List<LocationImage> LocationImages { get;  set; } = new  List<LocationImage>();

            public Location() { }
            
        }

    }
        