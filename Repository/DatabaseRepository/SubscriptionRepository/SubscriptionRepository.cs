using DAW2.Data;
using DAW2.Models;
using DAW2.Repository.GenericRepository;
using System.Linq;

namespace DAW2.Repository.DatabaseRepository.SubscriptionRepository
{
    public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionRepository
    {

        public SubscriptionRepository(DatabaseContext context) : base(context)
        {
            
        }

        public Subscription GetBySubscriptionName(string SubscriptionName)
        {
            return _table.FirstOrDefault(x => x.SubscriptionName.ToLower().Equals(SubscriptionName.ToLower()));
        }
    }
}
