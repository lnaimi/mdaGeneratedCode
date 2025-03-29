

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class AddressType : BaseEntity {


            public string Type { get;  set; }

            public string Description { get;  set; }

            public AddressType() { }
            
        }

    }
        