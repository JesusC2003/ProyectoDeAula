using System;


namespace Entidad
{
    public class Inventario
    {
        public Inventario() 
        {
            Id = 0;
            CodigoInventario=string.Empty;
            NombreInventario=string.Empty;
            CantidadDisponible = 0;
            Descripcion=string.Empty;
        }   

        public int Id { get; set; }
        public string CodigoInventario { get; set; }
        public string NombreInventario { get; set; }
        public int CantidadDisponible { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIngresoInventario { get; set; }

    }
}
