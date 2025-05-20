// Define el espacio de nombres (namespace) que agrupa lógicamente las clases modelo de la aplicación
namespace Demo.WebhookMVC.Models
{
    // Clase pública que representa los datos recibidos en un webhook
    public class WebhookRequest
    {
        // Propiedad pública que almacena el tipo de evento recibido (ejemplo: "payment_success")
        public string EventType { get; set; }

        // Propiedad pública que almacena el mensaje relacionado con el evento (ejemplo: "Pago exitoso de Javier")
        public string Message { get; set; }
    }
}
