using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Policia
    {
        public int Dni { get; }
        public string Nombre { get; }
        public int NumeroPlaca { get; }

        public Policia(int dni, string nombre, int numeroPlaca)
        {
            Dni = dni;
            Nombre = nombre;
            NumeroPlaca = numeroPlaca;
        }

        public string VerDatos()
        {
            return $@"Dni: {Dni} - Nombre: {Nombre} - N° Placa: {NumeroPlaca}";
        }
    }
}
