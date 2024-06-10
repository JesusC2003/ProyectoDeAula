using System;


namespace Entidad
{
    public class EntidadMedicamento
    {
        public EntidadMedicamento() 
        {
            IdMedicamento = 0;
            CodigoMedicamento=string.Empty;
            NombreMedicamento = string.Empty;
            DescripcionMedicamento = string.Empty;
        }

        public int IdMedicamento { get; set; }
        public string CodigoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public string DescripcionMedicamento { get; set; }
        public DateTime FechaCaducidad { get; set; }
    }
}
