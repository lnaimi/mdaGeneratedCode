

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Currency : BaseEntity {


            public string Name { get;  set; }

            public string Symbol { get;  set; }

            public string Code { get;  set; }

            public string Image { get;  set; }

            public List<Country> Countrys { get;  set; } = new  List<Country>();

            public Currency() { }
            
        }

    }
        