using System;


namespace Entidad
{
    public class Medicamento
    {
        public Medicamento() 
        {
            IdMedicamento = 0;
            NombreMedicamento = string.Empty;
            DescripcionMedicamento = string.Empty;
            IdInventario = new Inventario();
        }

        public int IdMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public string DescripcionMedicamento { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public Inventario IdInventario { get; set; }
    }
}
