

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    using SmartTourismApp.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    
    namespace SmartTourismApp.Infrastructure
    {
        
        public class SmartTourismAppContext : DbContext {


            public DbSet<Account> Accounts { get;  set; }

            public DbSet<User> Users { get;  set; }

            public DbSet<AcountAction> AcountActions { get;  set; }

            public DbSet<Location> Locations { get;  set; }

            public DbSet<Room> Rooms { get;  set; }

            public DbSet<LocationImage> LocationImages { get;  set; }

            public DbSet<Bed> Beds { get;  set; }

            public DbSet<Country> Countrys { get;  set; }

            public DbSet<City> Citys { get;  set; }

            public DbSet<Pricing> Pricings { get;  set; }

            public DbSet<UserAddress> UserAddresss { get;  set; }

            public DbSet<AddressType> AddressTypes { get;  set; }

            public DbSet<Currency> Currencys { get;  set; }

            public DbSet<UnitOfMeasurement> UnitOfMeasurements { get;  set; }

            public DbSet<Language> Languages { get;  set; }

            public DbSet<TranslatableText> TranslatableTexts { get;  set; }

            public DbSet<Translation> Translations { get;  set; }

            public DbSet<Money> Moneys { get;  set; }

            public DbSet<Rating> Ratings { get;  set; }

            public DbSet<Answer> Answers { get;  set; }

            public DbSet<ShareAction> ShareActions { get;  set; }

            public DbSet<LikeAction> LikeActions { get;  set; }

            public DbSet<Attraction> Attractions { get;  set; }

            public DbSet<Amenity> Amenitys { get;  set; }

            public SmartTourismAppContext() { }
            public SmartTourismAppContext(DbContextOptions options)
                
            {
                #region Constructor initialisation
                //
                
                #endregion
            }

            
        }

    }
        