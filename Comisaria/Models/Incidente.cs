using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Incidente
    {
        public string Motivo { get; }
        public int Hora { get; }
        public int Minuto { get; }
        public int Tipoincidente { get; }

        public Policia OficialACargo;
        public Persona Sujeto;

        public Incidente(Policia oficialACargo, Persona sujeto, int tipoIncidente)
        {
            OficialACargo = oficialACargo;
            Sujeto = sujeto;
            Tipoincidente = tipoIncidente;
        }

        public string VerDescripcion()
        {
            return $@"
            ""Oficial a cargo:"" {OficialACargo.Nombre} - {OficialACargo.Dni}
            ""Sujeto Denunciante:"" {Sujeto.Nombre} - {Sujeto.Dni}";
        }

    }
}
