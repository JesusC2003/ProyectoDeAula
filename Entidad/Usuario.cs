
namespace Entidad
{
    public class Usuario
    {
        public Usuario()
        {
            IdUsuario = 0;
            NombreUsuario=string.Empty;
            Contraseña=string.Empty;
        }

        public int IdUsuario {  get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
