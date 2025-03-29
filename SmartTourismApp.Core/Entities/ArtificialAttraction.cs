

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class ArtificialAttraction : Attraction {


            public DateTimeOffset OpeningTime { get;  set; }

            public DateTimeOffset ClosingTime { get;  set; }

            public DateTimeOffset ConstructionDate { get;  set; }

            public ArtificialAttraction() { }
            
        }

    }
        