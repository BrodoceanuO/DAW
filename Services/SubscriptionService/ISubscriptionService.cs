using DAW2.Models;
using System.Collections.Generic;

namespace DAW2.Services.SubscriptionService
{
    public interface ISubscriptionService
    {
        Subscription GetDataMappedBySubscriptionName(string LastName);

        //GET
        List<Subscription> GetAllSubscriptions();

        //UPDATE
        void UpdateSubscription(Subscription subscription);

        //DELETE
        void DeleteSubscription(Subscription subscription);

        //CREATE
        void CreateSubscription(Subscription subscription);

    }
}
