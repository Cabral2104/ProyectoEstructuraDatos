using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class ArbolBinario : IEstructuraDeDatos
    {
        private NodoArbol raiz;

        public void AgregarDato(string dato)
        {
            if (int.TryParse(dato, out int valor))
            {
                raiz = AgregarNodo(raiz, valor);
                Console.WriteLine($"{valor} agregado al árbol.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        private NodoArbol AgregarNodo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
            {
                return new NodoArbol(valor);
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierda = AgregarNodo(nodo.Izquierda, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecha = AgregarNodo(nodo.Derecha, valor);
            }

            return nodo;
        }

        public void EliminarDato(string dato)
        {
            if (int.TryParse(dato, out int valor))
            {
                if (BuscarNodo(raiz, valor) != null)
                {
                    raiz = EliminarNodo(raiz, valor);
                    Console.WriteLine($"{valor} eliminado del árbol.");
                }
                else
                {
                    Console.WriteLine($"{valor} no encontrado en el árbol.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        private NodoArbol EliminarNodo(NodoArbol nodo, int valor)
        {
            if (nodo == null)
            {
                return nodo;
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierda = EliminarNodo(nodo.Izquierda, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecha = EliminarNodo(nodo.Derecha, valor);
            }
            else
            {
                // Nodo encontrado, realizar la eliminación
                if (nodo.Izquierda == null)
                {
                    return nodo.Derecha;
                }
                else if (nodo.Derecha == null)
                {
                    return nodo.Izquierda;
                }

                // Reemplazar con el sucesor inmediato en orden (valor mínimo del subárbol derecho)
                nodo.Valor = EncontrarMinimoValor(nodo.Derecha);
                nodo.Derecha = EliminarNodo(nodo.Derecha, nodo.Valor);
            }

            return nodo;
        }

        private int EncontrarMinimoValor(NodoArbol nodo)
        {
            int minimoValor = nodo.Valor;
            while (nodo.Izquierda != null)
            {
                minimoValor = nodo.Izquierda.Valor;
                nodo = nodo.Izquierda;
            }
            return minimoValor;
        }

        public void MostrarDatos()
        {
             if (raiz == null)
        {
            Console.WriteLine("Árbol vacío.");
        }
        else
        {
            Console.WriteLine("Representación del Árbol Binario:");

            MostrarArbol(raiz, 0);
        }
        }

        private void MostrarArbol(NodoArbol nodo, int nivel)
        {
            if (nodo != null)
            {
                MostrarArbol(nodo.Derecha, nivel + 1);

                Console.Write(new string(' ', nivel * 4));
                Console.WriteLine($"{nodo.Valor}");

                MostrarArbol(nodo.Izquierda, nivel + 1);
            }
        }

        public void BuscarDato(string dato)
        {
            if (int.TryParse(dato, out int valor))
            {
                if (BuscarNodo(raiz, valor) != null)
                {
                    Console.WriteLine($"{valor} encontrado en el árbol.");
                }
                else
                {
                    Console.WriteLine($"{valor} no encontrado en el árbol.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        private NodoArbol BuscarNodo(NodoArbol nodo, int valor)
        {
            if (nodo == null || nodo.Valor == valor)
            {
                return nodo;
            }

            if (valor < nodo.Valor)
            {
                return BuscarNodo(nodo.Izquierda, valor);
            }

            return BuscarNodo(nodo.Derecha, valor);
        }

        public void AgregarArista(string datoOrigen, string datoDestino)
        {
            throw new NotImplementedException();
        }

        public void EliminarArista(string datoOrigen, string datoDestino)
        {
            throw new NotImplementedException();
        }

        public void MostrarGrafo()
        {
            throw new NotImplementedException();
        }
    }
}
