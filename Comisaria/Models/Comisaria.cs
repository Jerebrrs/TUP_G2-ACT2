using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Comisaria
    {
        public int CantidadInicidentes { get; private set; }

        List<Policia> agentes = new List<Policia>();
        public bool AsignarPolicia(Policia pol) {
            Policia poli = VerAgente(pol.NumeroPlaca);

            if (poli != null)
            {
                agentes.Add(pol);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Policia VerAgente(int nPlaca)
        {
            int idx = -1;
            int i = 0;
            for ( i = 0; i < agentes.Count; i++)
            {
                while (idx == -1 && i<agentes.Count)
                {
                    if (nPlaca == agentes[i].NumeroPlaca)
                    {
                        idx=i;
                    }
                }
            }

            if (idx!=-1)
            {
                return agentes[i];
            }
            else
            {
                return null;
            }
        }
        public void AsignarGuardia()
        {

        }

    }
}
