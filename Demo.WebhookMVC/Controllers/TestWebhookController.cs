using Microsoft.AspNetCore.Mvc;

namespace Demo.WebhookMVC.Controllers
{

    public class TestWebhookController : Controller
    {
        // Define una acción pública llamada 'Index'.
        // Esta acción responderá a la ruta por defecto asociada a este controlador, generalmente: /TestWebhook/Index
        public IActionResult Index()
        {
            // Retorna una vista HTML correspondiente al método Index (por convención buscará un archivo en Views/TestWebhook/Index.cshtml)
            return View();
        }
    }
}
