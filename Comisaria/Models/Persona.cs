using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaria.Models
{
    internal class Persona
    {
        public int Dni { get;}
        public string Nombre { get;}


        public Persona(int dni,string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public string VerDatos()
        {
            return $@"Dni: {Dni} - Nombre: {Nombre}";
        }
    }
}
