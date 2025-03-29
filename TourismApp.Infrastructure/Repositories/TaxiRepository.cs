
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourismApp.Core;
using TourismApp.Core.Interfaces;

namespace TourismApp.Infrastructure.Repositories
{
	public class TaxiRepository : EfRepository<Taxi>, ITaxiRepository
	{
		public TaxiRepository(TourismAppContext tourismAppContext) : base(tourismAppContext)
		{
		}
		
	
	
	}
}	
       