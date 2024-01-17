namespace WebAPINET8.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Constructor para establecer valores por defecto
        public Usuario()
        {
            FechaRegistro = DateTime.Now; // Valor por defecto para la fecha de registro
        }
    }
}
