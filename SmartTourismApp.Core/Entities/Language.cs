

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.SharedKernel;
    
    namespace SmartTourismApp.Core.Entities
    {
        
        public class Language : BaseEntity {


            public string Name { get;  set; }

            public string NativeName { get;  set; }

            public string Code { get;  set; }

            public List<User> Users { get;  set; } = new  List<User>();

            public List<Country> Countrys { get;  set; } = new  List<Country>();

            public Language() { }
            
        }

    }
        