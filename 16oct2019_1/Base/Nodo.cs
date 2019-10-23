using System;

namespace _16oct2019_1.Base
{
    public class Nodo
    {
        public int dato { get; set; }
        public Nodo sgte { get; set; }

        public Nodo(int dato)
        {
            this.dato = dato;
            this.sgte = null;            
        }
    }
}
