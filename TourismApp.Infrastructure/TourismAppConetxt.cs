
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourismApp.Core;

namespace TourismApp.Infrastructure
{
	public class TourismAppContext : DbContext
	{
	
	
		public TourismAppConetxt(DbContextOptions options) : base(options) { }
		
		public TourismAppContext() : base(new DbContextOptionsBuilder<TourismAppContext>()
						.UseSqlServer(@"Server=.;Database=TourismAppDB;Trusted_Connection=True;")
						.Options)
		{ }
	}
}	
       