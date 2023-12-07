using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Pila : IEstructuraDeDatos
    {
        private Stack<string> datos = new Stack<string>();

        public void AgregarDato(string dato)
        {
            datos.Push(dato);
        }

        public void EliminarDato(string dato)
        {
            if (datos.Contains(dato))
            {
                // La eliminación en una pila implica desapilar hasta encontrar el elemento
                Stack<string> nuevaPila = new Stack<string>();
                bool elementoEliminado = false;

                while (datos.Count > 0)
                {
                    string elemento = datos.Pop();
                    if (!elementoEliminado && elemento == dato)
                    {
                        // Eliminar solo la primera ocurrencia del elemento
                        elementoEliminado = true;
                    }
                    else
                    {
                        nuevaPila.Push(elemento);
                    }
                }

                // Restaurar la pila original
                while (nuevaPila.Count > 0)
                {
                    datos.Push(nuevaPila.Pop());
                }

                if (elementoEliminado)
                {
                    Console.WriteLine($"{dato} eliminado de la pila.");
                }
                else
                {
                    Console.WriteLine($"{dato} no encontrado en la pila.");
                }
            }
            else
            {
                Console.WriteLine($"{dato} no encontrado en la pila.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Pila: " + string.Join(", ", datos));
        }
    }

}
