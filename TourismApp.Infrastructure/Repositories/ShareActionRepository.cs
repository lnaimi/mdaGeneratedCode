
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourismApp.Core;
using TourismApp.Core.Interfaces;

namespace TourismApp.Infrastructure.Repositories
{
	public class ShareActionRepository : EfRepository<ShareAction>, IShareActionRepository
	{
		public ShareActionRepository(TourismAppContext tourismAppContext) : base(tourismAppContext)
		{
		}
		
	
	
	}
}	
       