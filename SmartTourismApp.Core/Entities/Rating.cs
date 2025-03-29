

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Rating : AcountAction {


            public double Value { get;  set; }

            public DateTimeOffset DateOfVisit { get;  set; }

            public TranslatableText Text { get;  set; }

            public Rating() { }
            
        }

    }
        