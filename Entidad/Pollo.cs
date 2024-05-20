using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pollo
    {
        public Pollo() { }
        public Pollo(string idPollo, string estado, DateTime fechaingreso, DateTime fechaSalida, string razaPollo, int periodoEngorde, double peso, Inventario codigolnventario, Galpon codigoGalpon, List<Aplicado> medicamentoAplicado)
        {
            IdPollo = idPollo;
            Estado = estado;
            Fechaingreso = fechaingreso;
            FechaSalida = fechaSalida;
            RazaPollo = razaPollo;
            PeriodoEngorde = periodoEngorde;
            Peso = peso;
            Codigolnventario = codigolnventario;
            CodigoGalpon = codigoGalpon;
            MedicamentoAplicado = medicamentoAplicado;
        }

        public override string ToString() => $"{IdPollo};{Estado};{Fechaingreso};{FechaSalida};{RazaPollo};{PeriodoEngorde};{Peso};";//{Codigolnventario};{CodigoGalpon};{MedicamentoAplicado}";

        public string IdPollo { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime Fechaingreso { get; set; } = DateTime.Today;
        public DateTime FechaSalida { get; set; }
        public string RazaPollo { get; set; } = string.Empty;
        public int PeriodoEngorde { get; set; } = 0;
        public double Peso { get; set; } = 0;
        public Inventario Codigolnventario { get; set; } 
        public Galpon CodigoGalpon { get; set; }
        public List<Aplicado> MedicamentoAplicado { get; set; }

    }
}
