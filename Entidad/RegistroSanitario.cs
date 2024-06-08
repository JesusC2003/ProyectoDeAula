using System;


namespace Entidad
{
    public class RegistroSanitario
    {
        public RegistroSanitario()
        {
            CodigoRegistro = string.Empty;
            Observaciones = string.Empty;
            IdPollo = new Pollo();
            IdMedicamento = new Medicamento();
        }       

        public string CodigoRegistro { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Observaciones { get; set; }
        public Pollo IdPollo { get; set; }
        public Medicamento IdMedicamento { get; set; }
    }
}
