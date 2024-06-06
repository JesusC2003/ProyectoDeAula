

namespace Entidad
{
    public class Empleado : Persona
    {
        public Empleado() 
        {
            Id = 0;
            Identificacion=string.Empty;
            TipoIdentificacion = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            CodigoEmpleado = string.Empty;
            Cargo = string.Empty;
            Salario = 0;
            Departamento=string.Empty;
        }
        
        public string CodigoEmpleado { get; set; }
        public string Cargo { get; set; } 
        public double Salario { get; set; }
        public string Departamento { get; set; } 
        public Empresa NitEmpresa { get; set; }
        public Usuario IdUsuario { get; set; }
    }
}
