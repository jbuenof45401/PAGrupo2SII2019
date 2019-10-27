using System;
using _16oct2019_1.Base;

namespace _16oct2019_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Prueba_InsertarNodoxPosicion();
            Prueba_Cola();
        }

        public static void Prueba_Lista() {
            MiLista lista = new MiLista();
            // lista.Adicionar(5);
            // lista.Adicionar(1);
            // lista.Adicionar(7);

            //lista.RemoverPrimero();
            // Nodo nodoPrimero = lista.ObteneryRemoverPrimero();
            // if(nodoPrimero!=null)
            //     Console.WriteLine($"El dato del 1° nodo es: {nodoPrimero.dato}"); //5

            lista.Mostrar(); //1, 7
        }

        public static void Prueba_InsertarNodoxPosicion() {
            MiLista lista = new MiLista();
            // lista.InsertarNodoxPosicion(new Nodo(10), 0);
            // lista.InsertarNodoxPosicion(new Nodo(20), 1);
            // lista.InsertarNodoxPosicion(new Nodo(30), 1);

            lista.Mostrar();
        }

        public static void Prueba_Cola() {
            int? dato = 0;
            Cola cola = new Cola();
            cola.Encolar(10);
            cola.Encolar(20);
            dato = cola.Desencolar(); //10
            Console.WriteLine($"Desencolado:{dato}"); //10
            dato = cola.Desencolar(); //20
            Console.WriteLine($"Desencolado:{dato}"); //20

            Console.WriteLine($"y en la cola quedo:");
            cola.Mostrar();
        }
    }
}
