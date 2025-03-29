

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel.Interfaces;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Attraction : Location, IAggregateRoot {


            public bool IsFreeAccess { get;  set; }

            public bool IsKidsAllowed { get;  set; }

            public Pricing EntranceFee { get;  set; }

            public DateTimeOffset SuggestedDuration { get;  set; }

            public TranslatableText SuggestedPeriod { get;  set; }

            public TranslatableText Instructions { get;  set; }

            public Attraction() { }
            
        }

    }
        