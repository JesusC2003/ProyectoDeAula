using System;


namespace Entidad
{
    public class RegistroSanitario
    {
        public RegistroSanitario()
        {
            CodigoRegistro = string.Empty;
            Observaciones = string.Empty;
        }       

        public string CodigoRegistro { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Observaciones { get; set; }
        public Pollo IdPollo { get; set; }
        public Medicamento IdMedicamento { get; set; }
    }
}
