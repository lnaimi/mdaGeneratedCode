

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Museum : ArtificialAttraction {


            public int NumberOfExhibits { get;  set; }

            public Museum() { }
            
        }

    }
        