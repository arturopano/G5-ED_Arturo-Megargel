using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlizadas
{
    //la estructar de los elemntods que se agregara a la lista 
    class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
}
