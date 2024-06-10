using System;


namespace Entidad
{
    public class RegistroSanitario
    {
        public RegistroSanitario()
        {
            IdRegistro = 0;
            Observaciones = string.Empty;
            IdPollo = new Pollo();
            IdMedicamento = new Medicamento();
        }       

        public int IdRegistro { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Observaciones { get; set; }
        public Pollo IdPollo { get; set; }
        public Medicamento IdMedicamento { get; set; }
    }
}
