

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Room : BaseEntity {


            public TranslatableText Name { get;  set; }

            public TranslatableText Description { get;  set; }

            public string RoomType { get;  set; }

            public bool Tv { get;  set; }

            public bool Wifi { get;  set; }

            public bool AirConditioner { get;  set; }

            public Pricing Price { get;  set; }

            public List<Amenity> Amenitys { get;  set; } = new  List<Amenity>();

            public List<Bed> Beds { get;  set; } = new  List<Bed>();

            public Room() { }
            
        }

    }
        