namespace TiendaAPI.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public required string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        
    }
}