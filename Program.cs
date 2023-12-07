using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
      
        public interface IEstructuraDeDatos
        {
        void AgregarDato(string dato);
        void EliminarDato(string dato);
        void MostrarDatos();
        }

        public class Program
        {
            static void Main()
            {
            IEstructuraDeDatos estructuraActual = null;

            while (true)
            {
                Menu.MostrarMenu();
                string opcion1 = Console.ReadLine();
                if (opcion1 == "5")
                {
                    
                    if (estructuraActual != null)
                    {
                        Console.WriteLine($"Seleccionaste {opcion1}. Puedes realizar operaciones en {estructuraActual.GetType().Name}.");

                        while (true)
                        {
                            MostrarOperacionesGrafos();
                            string operacionGrafos = Console.ReadLine();

                            if (RealizarOperacionGrafos(estructuraActual, operacionGrafos))
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Por favor, seleccione una estructura válida.");
                    }
                }
            
                else if (opcion1 == "6")
                {
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                }

                estructuraActual = Menu.SeleccionarEstructura(opcion1);

                if (estructuraActual != null)
                {
                    Console.WriteLine($"Seleccionaste {opcion1}. Puedes realizar operaciones en {estructuraActual.GetType().Name}.");

                    while (true)
                    {
                        MostrarOperaciones();
                        string operacion = Console.ReadLine();

                        if (RealizarOperacion(estructuraActual, operacion))
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una estructura válida.");
                }
            }

        }
        static void MostrarOperaciones()
        {
            Console.WriteLine("\nOperaciones:");
            Console.WriteLine("1. Agregar dato");
            Console.WriteLine("2. Eliminar dato");
            Console.WriteLine("3. Mostrar datos");
            Console.WriteLine("4. Cambiar estructura");
            Console.WriteLine("5. Salir");
        }
        static void MostrarOperacionesGrafos()
        {
            Console.WriteLine("\nOperaciones:");
            Console.WriteLine("1. Agregar Vertice");
            Console.WriteLine("2. Eliminar Vertice");
            Console.WriteLine("3. Agregar Arista");
            Console.WriteLine("4. Eliminar Arista");
            Console.WriteLine("5. Mostrar Grafo");
            Console.WriteLine("6. Salir");

        }
        static bool RealizarOperacion(IEstructuraDeDatos estructura, string operacion1)
        {
            switch (operacion1)
            {
                case "1":
                    Console.Write("Ingrese un dato: ");
                    string datoAgregar = Console.ReadLine();
                    estructura.AgregarDato(datoAgregar);
                    return false;
                case "2":
                    Console.Write("Ingrese el dato a eliminar: ");
                    string datoEliminar = Console.ReadLine();
                    estructura.EliminarDato(datoEliminar);
                    return false;
                case "3":
                    estructura.MostrarDatos();
                    return false;
                case "4":
                    Console.WriteLine("Cambiando estructura.");
                    return true;
                case "5":
                    Console.WriteLine("Saliendo de la estructura actual.");
                    return true;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
                    return false;
            }
        }
        static bool RealizarOperacionGrafos(IEstructuraDeDatos estructura, string operacion1)
        {

            switch (operacion1)
            {
                case "1":
                    Console.Write("Ingrese un Vertice: ");
                    string datoAgregar = Console.ReadLine();
                    estructura.AgregarDato(datoAgregar);
                    return false;
                case "2":
                    Console.Write("Ingrese el dato a eliminar: ");
                    string datoEliminar = Console.ReadLine();
                    estructura.EliminarDato(datoEliminar);
                    return false;
                case "3":

                    Console.Write("Ingrese el dato de origen: ");
                    string datoOrigen = Console.ReadLine();
                    Console.Write("Ingrese el dato de destino: ");
                    string datoDestino = Console.ReadLine();
                    ((Grafo)estructura).AgregarVertice(datoOrigen, datoDestino); // Llamada al método AgregarVertice
                    return false;
                case "4":
                    Console.Write("Ingrese el dato de origen: ");
                    string datoOrigenEliminar = Console.ReadLine();
                    Console.Write("Ingrese el dato de destino: ");
                    string datoDestinoEliminar = Console.ReadLine();
                    ((Grafo)estructura).EliminarVertice(datoOrigenEliminar, datoDestinoEliminar); // Llamada al método EliminarVertice
                    return false;
                case "5":
                    estructura.MostrarDatos();
                    return false;
                case "6":
                    Console.WriteLine("Saliendo de la estructura actual.");
                    return false;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
                    return false;
            }
        }
    } 
}






