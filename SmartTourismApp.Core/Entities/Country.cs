

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Country : BaseEntity {


            public string Name { get;  set; }

            public TranslatableText DisplayName { get;  set; }

            public string ThreeLetterCode { get;  set; }

            public string TwoLetterCode { get;  set; }

            public TranslatableText ShortName { get;  set; }

            public Currency Currency { get;  set; }

            public List<City> Citys { get;  set; } = new  List<City>();

            public List<Language> Languages { get;  set; } = new  List<Language>();

            public List<City> Citys { get;  set; } = new  List<City>();

            public Country() { }
            
        }

    }
        