using System;
using _16oct2019_1.Base;

namespace _16oct2019_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MiLista lista = new MiLista();
            lista.Adicionar(5);
            lista.Adicionar(1);
            lista.Adicionar(7);

            //lista.RemoverPrimero();
            Nodo nodoPrimero = lista.ObteneryRemoverPrimero();
            if(nodoPrimero!=null)
                Console.WriteLine($"El dato del 1° nodo es: {nodoPrimero.dato}"); //5

            lista.Mostrar(); //1, 7
        }
    }
}
