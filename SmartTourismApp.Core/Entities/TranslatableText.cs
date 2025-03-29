

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class TranslatableText : BaseEntity {


            public string DefaultValue { get;  set; }

            public List<Translation> Translations { get;  set; } = new  List<Translation>();

            public TranslatableText() { }
            
        }

    }
        