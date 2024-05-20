using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Galpon
    {
        public Galpon() { }
        public Galpon(string idGalpon, string estado, DateTime fechaCreacion, int capacidadMaxima, Alimento codigoAlimento)
        {
            IdGalpon = idGalpon;
            Estado = estado;
            FechaCreacion = fechaCreacion;
            CapacidadMaxima = capacidadMaxima;
            CodigoAlimento = codigoAlimento;
        }
        public override string ToString() => $"{IdGalpon};{Estado};{FechaCreacion};{CapacidadMaxima};{CodigoAlimento};";

        public string IdGalpon { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Today;
        public int CapacidadMaxima { get; set; } = 0;
        public Alimento CodigoAlimento { get; set; } 
        public List<Pollo> PolloId { get; set; }
    }
}
