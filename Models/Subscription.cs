using DAW2.Models.Base;
using System.Collections.Generic;

namespace DAW2.Models
{
    public class Subscription : BaseEntity
    {

        public string SubscriptionName { get; set; }
        public int Price { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
