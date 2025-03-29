

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class GuestHouse : Amenity {


            public int NumberOfFloors { get;  set; }

            public GuestHouse() { }
            
        }

    }
        