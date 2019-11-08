using System;

namespace _30oct2019_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prueba_Arbol_Insertar();
        }

        public static void Prueba_Arbol_Insertar() {
            ArbolBinBusqueda arbol = new ArbolBinBusqueda();
            // arbol.Insertar(new Nodo(80));
            // arbol.Insertar(new Nodo(40));
            // arbol.Insertar(new Nodo(50));

            Console.WriteLine(arbol.ExisteNodo(100));
        }
    }
}
