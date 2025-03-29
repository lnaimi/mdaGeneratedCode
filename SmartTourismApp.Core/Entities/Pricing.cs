

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Pricing : BaseEntity {


            private UnitOfMeasurement _unitOfMeasurement;

            private Money _money;

            public Pricing() { }
            
        }

    }
        