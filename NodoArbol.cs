using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class NodoArbol
    {
        public int Valor { get; set; }
        public NodoArbol Izquierda { get; set; }
        public NodoArbol Derecha { get; set; }

        public NodoArbol(int valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }
}
