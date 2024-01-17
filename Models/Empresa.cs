namespace WebAPINET8.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }

        // Relación uno a muchos con Usuario
        public List<Usuario>? Usuarios { get; set; }
    }
}
