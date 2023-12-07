using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Menu
    {
         public static void MostrarMenu()
            {
                Console.WriteLine("A. Listas");
                Console.WriteLine("B. Pilas");
                Console.WriteLine("C. Colas");
                Console.WriteLine("D. Árboles");
                Console.WriteLine("E. Grafos");
                Console.WriteLine("F. Salir");
            }
       

        public static IEstructuraDeDatos SeleccionarEstructura(string opcion1)
            {

                switch (opcion1)
                {
                    case "A":
                        return new Lista();
                    // Agrega más casos para otras estructuras de datos según sea necesario
                    case "B":
                        return new Pila();
                    
                    case "C":
                        return new Cola();
                    case "D":
                        return new ArbolBinario();
                case "E":
                    return new Grafo();



                default:

                    return null;
                }
            }
     
    }
}
