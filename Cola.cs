using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Cola : IEstructuraDeDatos
    {
        private Queue<string> datos = new Queue<string>();

        public void AgregarDato(string dato)
        {
            datos.Enqueue(dato);
        }

        public void EliminarDato(string dato)
        {
            if (datos.Contains(dato))
            {
                // La eliminación en una cola implica desencolar hasta encontrar el elemento
                Queue<string> nuevaCola = new Queue<string>();
                bool elementoEliminado = false;

                while (datos.Count > 0)
                {
                    string elemento = datos.Dequeue();
                    if (!elementoEliminado && elemento == dato)
                    {
                        // Eliminar solo la primera ocurrencia del elemento
                        elementoEliminado = true;
                    }
                    else
                    {
                        nuevaCola.Enqueue(elemento);
                    }
                }

                // Restaurar la cola original
                while (nuevaCola.Count > 0)
                {
                    datos.Enqueue(nuevaCola.Dequeue());
                }

                if (elementoEliminado)
                {
                    Console.WriteLine($"{dato} eliminado de la cola.");
                }
                else
                {
                    Console.WriteLine($"{dato} no encontrado en la cola.");
                }
            }
            else
            {
                Console.WriteLine($"{dato} no encontrado en la cola.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Cola: " + string.Join(", ", datos));
        }
    }
}
