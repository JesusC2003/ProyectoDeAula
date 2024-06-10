
namespace Entidad
{
    public class Usuario
    {
        public Usuario()
        {
            IdUsuario = 0;
            NombreUsuario=string.Empty;
            ContraseñaUsuario=string.Empty;
        }

        public int IdUsuario {  get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
    }
}
