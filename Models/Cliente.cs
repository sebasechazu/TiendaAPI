namespace TiendaAPI.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public required string Nombre { get; set; }
        public required string Email { get; set; }
    }
}
