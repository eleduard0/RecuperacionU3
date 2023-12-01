using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionU3
{
    public class Nodo
    {
        private Nodo _Siguiente;
        private Carro _datosCarro;

        public Nodo Siguiente;
        public Carro DatosCarro;

        public Nodo(Carro carro)
        {
            DatosCarro = carro;
            Siguiente = null;
        }
    }
}
