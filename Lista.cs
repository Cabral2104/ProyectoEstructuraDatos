using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Lista : IEstructuraDeDatos
    {
        private List<string> datos = new List<string>();

        public void AgregarDato(string dato)
        {
            datos.Add(dato);
        }

        public void EliminarDato(string dato)
        {
            if (datos.Contains(dato))
            {
                datos.Remove(dato);
                Console.WriteLine($"{dato} eliminado de la lista.");
            }
            else
            {
                Console.WriteLine($"{dato} no encontrado en la lista.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Lista: " + string.Join(", ", datos));
        }
    }

}
