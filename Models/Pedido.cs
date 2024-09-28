namespace TiendaAPI.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public DateTime Fecha { get; set; }
        public required Cliente Cliente { get; set; }
    }
}
