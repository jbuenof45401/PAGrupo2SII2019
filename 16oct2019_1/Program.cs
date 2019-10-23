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

            lista.Mostrar();
        }
    }
}
