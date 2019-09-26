using System;

namespace _25sept2019_1
{
    public class Programa
    {        
        public static void Main(string[] args)
        {
            Cliente cliente = null;

            cliente = new Cliente();
            //el codigo para validacion XXXXXXX            
            cliente.Nit = "123abc";
            //cliente.ValidarNit(cliente.nit);

            //operaria al obj cliente
            Console.WriteLine(cliente.Nit);
        }
    }
}
