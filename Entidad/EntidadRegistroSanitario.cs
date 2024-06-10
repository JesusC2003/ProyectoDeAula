using System;


namespace Entidad
{
    public class EntidadRegistroSanitario
    {
        public EntidadRegistroSanitario()
        {
            IdRegistro = 0;
            Observaciones = string.Empty;
            IdPollo = new EntidadPollo();
            IdMedicamento = new EntidadMedicamento();
        }       

        public int IdRegistro { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Observaciones { get; set; }
        public EntidadPollo IdPollo { get; set; }
        public EntidadMedicamento IdMedicamento { get; set; }
    }
}
