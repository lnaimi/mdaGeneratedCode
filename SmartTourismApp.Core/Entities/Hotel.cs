

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Hotel : Amenity {


            public HotelClassification Classification { get;  set; }

            public AmenityRecreationalFacilities RecreationalFacilities { get;  set; }

            public Hotel() { }
            
        }

    }
        