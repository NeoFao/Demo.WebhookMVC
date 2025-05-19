namespace Demo.WebhookMVC.Models
{
    public class WebhookRequest
    {
        public string EventType { get; set; }
        public string Message { get; set; }
    }
}
