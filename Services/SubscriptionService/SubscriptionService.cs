using DAW2.Data;
using DAW2.Models;
using DAW2.Repository.DatabaseRepository.SubscriptionRepository;
using DAW2.Utilities.JWTUtils;
using System.Collections.Generic;

namespace DAW2.Services.SubscriptionService
{
    public class SubscriptionService: ISubscriptionService
    {
        public ISubscriptionRepository _subscriptionRepository;
        public DatabaseContext databaseContext;

        public SubscriptionService(ISubscriptionRepository userRepository)
        {
            _subscriptionRepository = userRepository;
        }

        public Subscription GetDataMappedBySubscriptionName(string SubscriptionName)
        {
            Subscription subscription = _subscriptionRepository.GetBySubscriptionName(SubscriptionName);
            return subscription;

        }

        public List<Subscription> GetAllSubscriptions()
        {
            return _subscriptionRepository.GetAll().Result;
        }

        public void UpdateSubscription(Subscription subscription)
        {
            _subscriptionRepository.Update(subscription);
            _subscriptionRepository.Save();
        }

        public void DeleteSubscription(Subscription subscription)
        {
            _subscriptionRepository.Delete(subscription);
            _subscriptionRepository.Save();
        }

        public void CreateSubscription(Subscription subscription)
        {
            _subscriptionRepository.Create(subscription);
            _subscriptionRepository.Save();
        }
    }
}
