

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Translation : BaseEntity {


            public string Value { get;  set; }

            public Language Language { get;  set; }

            public int TranslatableTextId { get;  set; }

            public TranslatableText TranslatableText { get;  set; }

            public Translation() { }
            
        }

    }
        