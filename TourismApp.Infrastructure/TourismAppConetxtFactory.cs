
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TourismApp.Infrastructure
{
	public class TourismAppContextFactory : IDesignTimeDbContextFactory<TourismAppContext>
	{	
		public TourismAppConetxt CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<TourismAppContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=TourismAppDB;Trusted_Connection=True;");

            return new TourismAppContext(optionsBuilder.Options);
		}
	}
}	
       