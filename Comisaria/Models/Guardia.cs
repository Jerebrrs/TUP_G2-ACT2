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
        public int HoraHasta { get; private set; }
        public int MinutoHasta { get; private set; }
        public int CantidadMinutos { get; private set; }

        public Policia OficialAsignado;
        //public Guardia(int hi,int mi,int hf,int mf,int cantMin) 
        //{
        //    //HoraDesde = hi;
        //    //MinutoDesde= mi;
        //    //HoraHasta = hf;
        //    //MinutoHasta = mf;
        //    //CantidadMinutos = cantMin;
        //}
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
