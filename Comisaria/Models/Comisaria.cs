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

        public List<Policia> agentes = new List<Policia>();

        public List<Guardia> guardias = new List<Guardia>();
        public Comisaria()
        {
          
        }
        public bool AsignarPolicia(Policia pol) {
            agentes.Add(pol);
            return true;
        }
        public Policia VerAgente(int nPlaca)
        {
            for (int i = 0; i < agentes.Count; i++)
            {
                if (agentes[i].NumeroPlaca == nPlaca)
                {
                    return agentes[i];
                }
            }
            return null;
        }
        public void AsignarGuardia(int guardia, int h1, int m1, int tiemMinut, int placaAgente)
        {
            Guardia guardiaNueva = new Guardia();



            Policia agente = VerAgente(placaAgente);


            if (agente != null)
            {
                guardiaNueva.AsignarPolicia(agente, h1, m1, tiemMinut);
                guardias.Add(guardiaNueva);

            }
        }

    }
}
