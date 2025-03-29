

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class City : BaseEntity {


            public string Name { get;  set; }

            public string Latitude { get;  set; }

            public string Longitude { get;  set; }

            public int CountryId { get;  set; }

            public Country Country { get;  set; }

            public int CountryId { get;  set; }

            public Country Country { get;  set; }

            public City() { }
            
        }

    }
        