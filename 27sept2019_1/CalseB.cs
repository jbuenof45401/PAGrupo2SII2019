using System;

namespace _27sept2019_1
{
    public class ClaseB : ClaseA
    {
        public string nombre { get; set; }

        public void m2() {
            Console.WriteLine("m2 desde ClaseB");
        }

        public ClaseB() {
        }
    }
}
