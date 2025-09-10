namespace mvcProyect.Models
{
    public class HomeModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Mensaje { get; internal set; }
    }
}
