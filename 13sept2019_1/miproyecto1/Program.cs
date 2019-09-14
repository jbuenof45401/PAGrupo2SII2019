using System;
using miproyecto2;

namespace miproyecto1
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            int r = 0;
            r = Operacion.sumar(100, 200);
            Console.WriteLine("Resultado sumar: " + r);

            r = Operacion.restar(200, 100);
            Console.WriteLine("Resultado restar: " + r);
        }
    }
}
