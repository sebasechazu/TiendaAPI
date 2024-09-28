namespace TiendaAPI.Models
{
    public class DetallePedido
    {
        public int DetalleID { get; set; }
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }

        public required Pedido Pedido { get; set; }
        public required Producto Producto { get; set; }
    }
}
