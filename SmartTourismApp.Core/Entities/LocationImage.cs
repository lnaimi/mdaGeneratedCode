

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class LocationImage : BaseEntity {


            public string ImageLink { get;  set; }

            public TranslatableText Title { get;  set; }

            public int LocationId { get;  set; }

            public Location Location { get;  set; }

            public LocationImage() { }
            
        }

    }
        