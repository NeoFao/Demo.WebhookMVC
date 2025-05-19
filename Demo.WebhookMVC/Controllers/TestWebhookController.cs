using Microsoft.AspNetCore.Mvc;

namespace Demo.WebhookMVC.Controllers
{
    public class TestWebhookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
