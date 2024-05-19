using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Alimento
    {
        public Alimento(string codigoAlimento, string marca, double precioAlimento, string tipoAlimento, int cantidadAlimento, int frecuenciaAlimento, Inventario inventarioNombre)
        {
            CodigoAlimento = codigoAlimento;
            Marca = marca;
            PrecioAlimento = precioAlimento;
            TipoAlimento = tipoAlimento;
            CantidadAlimento = cantidadAlimento;
            FrecuenciaAlimento = frecuenciaAlimento;
            InventarioNombre = inventarioNombre;
        }

        public override string ToString() => $"{CodigoAlimento};{Marca};{PrecioAlimento};{TipoAlimento};{CantidadAlimento};{FrecuenciaAlimento};{InventarioNombre};";


        public string CodigoAlimento { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public double PrecioAlimento { get; set; } = 0;
        public string TipoAlimento { get; set; } = string.Empty;
        public int CantidadAlimento { get; set; } = 0;
        public int FrecuenciaAlimento { get; set; } = 0;
        public Inventario InventarioNombre { get; set; }
    }
}
