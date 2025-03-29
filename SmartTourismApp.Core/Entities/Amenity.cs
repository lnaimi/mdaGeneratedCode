

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel.Interfaces;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Amenity : Location, IAggregateRoot {


            public string Phone { get;  set; }

            public float Discount { get;  set; }

            public float Occupancy { get;  set; }

            public string Mail { get;  set; }

            public int AmenityId { get;  set; }

            public Amenity Amenity { get;  set; }

            public List<Room> Rooms { get;  set; } = new  List<Room>();

            public Amenity() { }
            
        }

    }
        