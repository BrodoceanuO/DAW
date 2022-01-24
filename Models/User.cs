using DAW2.Models.Base;
using System;
using System.Text.Json.Serialization;

namespace DAW2.Models
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
        public Role Role { get; set; }

        public Subscription Subscription { get; set; }
        public Guid SubscriptionId { get; set; }
    }
}
