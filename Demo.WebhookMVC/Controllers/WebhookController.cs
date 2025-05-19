using Demo.WebhookMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebhookMVC.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class WebhookController : ControllerBase
        {
            [HttpPost]
            public IActionResult ReceiveWebhook([FromBody] WebhookRequest request)
            {
                if (request == null)
                    return BadRequest("Invalid payload");

                Console.WriteLine($"Event: {request.EventType}, Message: {request.Message}");

                return Ok("Webhook received");
            }
        }
    
}
