namespace mvcProyect.Models
{
    public class PedidoModel
    {
    public int id { get; set; }
    public DateTime FechaPedido { get; set; }
    public int IdCliente { get; set; }
    public string Estado { get; set; }
    public decimal MontoDecimal { get; set; }
    public ClienteModel Cliente { get; set; }
    public ICollection<DetallePedidoModel> DetallePedidos { get; set; }
    }
}
