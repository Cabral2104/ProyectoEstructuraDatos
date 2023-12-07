using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Grafo : IEstructuraDeDatos
    {
        private Dictionary<string, List<string>> vertices;
        private List<(string, string)> aristas;

        public Grafo()
        {
            vertices = new Dictionary<string, List<string>>();
            aristas = new List<(string, string)>();
        }

        public void AgregarDato(string dato)
        {
            if (!vertices.ContainsKey(dato))
            {
                vertices[dato] = new List<string>();
                Console.WriteLine($"Vertice '{dato}' agregado al grafo.");
            }
            else
            {
                Console.WriteLine($"El vertice '{dato}' ya existe en el grafo.");
            }
        }

        public void EliminarDato(string dato)
        {
            if (vertices.ContainsKey(dato))
            {
                vertices.Remove(dato);
                // Eliminar aristas relacionadas con el vértice
                aristas.RemoveAll(a => a.Item1 == dato || a.Item2 == dato);
                Console.WriteLine($"Vertice '{dato}' eliminado del grafo.");
            }
            else
            {
                Console.WriteLine($"El vertice '{dato}' no encontrado en el grafo.");
            }
        }

        public void AgregarVertice(string datoOrigen, string datoDestino)
        {
            if (vertices.ContainsKey(datoOrigen) && vertices.ContainsKey(datoDestino))
            {
                aristas.Add((datoOrigen, datoDestino));
                Console.WriteLine($"Arista entre '{datoOrigen}' y '{datoDestino}' agregada.");
            }
            else
            {
                Console.WriteLine("Al menos uno de los vértices no encontrado en el grafo.");
            }
        }

        public void EliminarVertice(string datoOrigen, string datoDestino)
        {
            if (vertices.ContainsKey(datoOrigen) && vertices.ContainsKey(datoDestino))
            {
                aristas.Remove((datoOrigen, datoDestino));
                Console.WriteLine($"Arista entre '{datoOrigen}' y '{datoDestino}' eliminada.");
            }
            else
            {
                Console.WriteLine("Al menos uno de los vértices no encontrado en el grafo.");
            }
        }
        public void AgregarArista(string datoOrigen, string datoDestino)
        {
            if (vertices.ContainsKey(datoOrigen) && vertices.ContainsKey(datoDestino))
            {
                aristas.Add((datoOrigen, datoDestino));
                Console.WriteLine($"Arista entre '{datoOrigen}' y '{datoDestino}' agregada.");
            }
            else
            {
                Console.WriteLine("Al menos uno de los vértices no encontrado en el grafo.");
            }
        }

        public void EliminarArista(string datoOrigen, string datoDestino)
        {
            if (vertices.ContainsKey(datoOrigen) && vertices.ContainsKey(datoDestino))
            {
                var arista = (datoOrigen, datoDestino);
                if (aristas.Contains(arista))
                {
                    aristas.Remove(arista);
                    Console.WriteLine($"Arista entre '{datoOrigen}' y '{datoDestino}' eliminada.");
                }
                else
                {
                    Console.WriteLine($"Arista entre '{datoOrigen}' y '{datoDestino}' no encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Al menos uno de los vértices no encontrado en el grafo.");
            }
        }

        public void MostrarGrafo()
        {
            if (vertices.Count == 0)
            {
                Console.WriteLine("Grafo vacío.");
            }
            else
            {
                Console.WriteLine("Lista de Vértices:");
                foreach (var vertice in vertices.Keys)
                {
                    Console.WriteLine(vertice);
                }

                Console.WriteLine("Lista de Aristas:");
                foreach (var arista in aristas)
                {
                    Console.WriteLine($"{arista.Item1} - {arista.Item2}");
                }
            }
        }

        public void MostrarDatos()
        {
            MostrarGrafo();
        }
    }

}
