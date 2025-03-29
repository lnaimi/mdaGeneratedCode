

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class UnitOfMeasurement : BaseEntity {


            private string _name;

            private string _code;

            public UnitOfMeasurement() { }
            
        }

    }
        