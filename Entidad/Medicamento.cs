using System;


namespace Entidad
{
    public class Medicamento
    {
        public Medicamento() {
            CodigoMedicamento = string.Empty;
            NombreMedicamento = string.Empty;
            Descripcion = string.Empty;
        }

        public int IdMedicamento { get; set; }
        public string CodigoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public Inventario IdInventario { get; set; }
    }
}
