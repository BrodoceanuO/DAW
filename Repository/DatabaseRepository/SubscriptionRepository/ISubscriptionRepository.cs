using DAW2.Models;
using DAW2.Repository.GenericRepository;

namespace DAW2.Repository.DatabaseRepository.SubscriptionRepository
{
    public interface ISubscriptionRepository: IGenericRepository<Subscription>
    {
        Subscription GetBySubscriptionName(string SubscriptionName);
    }
}
