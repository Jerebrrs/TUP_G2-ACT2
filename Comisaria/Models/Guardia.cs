using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Guardia
    {

        public int HoraDesde { get; private set; }
        public int MinutoDesde { get; private set; }
        public int HoraHasta { get; }
        public int MinutoHasta { get; }
        public int CantidadMinutos { get; private set; }

        public Policia OficialAsignado;
        public Guardia() { }

        public void AsignarPolicia(Policia pol, int h, int m, int cantM)
        {
            OficialAsignado = pol;
            HoraDesde = h;
            MinutoDesde = m;
            CantidadMinutos= cantM;
        }

    }
}
