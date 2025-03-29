

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Bed : BaseEntity {


            public string Id { get;  set; }

            public int Quantity { get;  set; }

            public List<Room> Rooms { get;  set; } = new  List<Room>();

            public Bed() { }
            
        }

    }
        