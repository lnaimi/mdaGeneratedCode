

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Mountain : NaturalAtrraction {


            public float Height { get;  set; }

            public TranslatableText ClimbingOpportunities { get;  set; }

            public Mountain() { }
            
        }

    }
        