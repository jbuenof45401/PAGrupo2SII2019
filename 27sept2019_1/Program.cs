using System;

namespace _27sept2019_1
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            ClaseA ca = new ClaseA {
                nit = 123
            };
            ClaseB cb = new ClaseB {
                nit = 456,
                nombre = "oskitar"
            };

            //ClaseA cab = cb;
            ClaseB cba = (ClaseB)ca;

            //Console.WriteLine(cab);
        }
    }
}
