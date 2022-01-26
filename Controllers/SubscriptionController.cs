using DAW2.Data;
using DAW2.Models;
using DAW2.Services.SubscriptionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        private readonly ISubscriptionService _subscriptionService;

        /*
        public SubscriptionController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        */

        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        //GET
        [HttpGet]
        public IActionResult GetAllSubscriptions()
        {
            var subscriptions = _subscriptionService.GetAllSubscriptions();
            return Ok(subscriptions);
        }


        //PUT
        [HttpPut("UpdateSubscription")]
        public IActionResult Update(Subscription subscription)
        {
            _subscriptionService.UpdateSubscription(subscription);
            return Ok();
        }

        //DELETE
        [HttpDelete("DeleteSubscription")]
        public IActionResult Delete(Subscription subscription)
        {
            _subscriptionService.DeleteSubscription(subscription);
            return Ok();
        }

        //CREATE
        [HttpPost("CreateSubscription")]
        public IActionResult Create(Subscription subscription)
        {
            _subscriptionService.CreateSubscription(subscription);
            return Ok();
        }
    }
}
