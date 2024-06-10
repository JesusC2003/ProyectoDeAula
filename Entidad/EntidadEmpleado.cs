

namespace Entidad
{
    public class EntidadEmpleado : EntidadPersona
    {
        public EntidadEmpleado() 
        {
            Id = 0;
            Identificacion=string.Empty;
            TipoIdentificacion = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            Cargo = string.Empty;
            Salario = 0;
            Departamento=string.Empty;
            NitEmpresa = new EntidadEmpresa();
            IdUsuario = new EntidadUsuario();
        }
        public string Cargo { get; set; } 
        public double Salario { get; set; }
        public string Departamento { get; set; } 
        public EntidadEmpresa NitEmpresa { get; set; }
        public EntidadUsuario IdUsuario { get; set; }
    }
}
