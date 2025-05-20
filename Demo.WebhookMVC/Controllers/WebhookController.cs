
using Demo.WebhookMVC.Models;
using Microsoft.AspNetCore.Mvc;

// Importa el sistema de logging (registro de eventos) de ASP.NET Core
using Microsoft.Extensions.Logging;


namespace Demo.WebhookMVC.Controllers
{
    // Marca esta clase como un controlador de API, habilita validaciones automáticas y comportamiento específico de API REST
    [ApiController]

    // Define la ruta base del controlador como "api/webhook". El [controller] será reemplazado por el nombre del controlador sin "Controller".
    [Route("api/[controller]")]

    // Define la clase WebhookController, que maneja solicitudes HTTP para webhooks. Hereda de ControllerBase porque no usa vistas HTML.
    public class WebhookController : ControllerBase
    {
        // Declaración de un campo solo lectura (_logger) que permite registrar mensajes en la consola o en archivos/logs.
        private readonly ILogger<WebhookController> _logger;

        // Constructor del controlador que recibe un objeto logger a través de inyección de dependencias (Dependency Injection)
        public WebhookController(ILogger<WebhookController> logger)
        {
            // Se asigna el logger recibido al campo privado para usarlo en otros métodos
            _logger = logger;
        }

        // Define un método que responderá a solicitudes HTTP POST en la ruta "api/webhook"
        [HttpPost]

        // Método que recibe los datos del webhook como un objeto WebhookRequest desde el cuerpo de la solicitud (JSON)
        public IActionResult ReceiveWebhook([FromBody] WebhookRequest request)
        {
            // Verifica si el objeto recibido es nulo. Esto puede pasar si el cuerpo del JSON está malformado o vacío.
            if (request == null)
                // Devuelve un código de estado HTTP 400 (Bad Request) con un mensaje personalizado
                return BadRequest("Invalid payload");

            // Registra un mensaje informativo en el log del servidor con los datos del evento recibido
            _logger.LogInformation("Event: {EventType}, Message: {Message}", request.EventType, request.Message);

            // Devuelve un código de estado HTTP 200 (OK) confirmando que el webhook fue recibido correctamente
            return Ok("Webhook received");
        }
    }

}
