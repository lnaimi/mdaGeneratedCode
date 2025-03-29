

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Forest : NaturalAtrraction {


            public TranslatableText Type { get;  set; }

            public Forest() { }
            
        }

    }
        