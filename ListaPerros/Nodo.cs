using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPerros
{
    public class Nodo
    {
        public Perro DatosPerro {  get; set; }
        public Nodo Siguiente {  get; set; }

        public Nodo(Perro perro)
        {
            DatosPerro = perro;
            Siguiente = null;
        }
    }
}
