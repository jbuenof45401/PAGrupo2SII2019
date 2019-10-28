using System;

namespace _16oct2019_1.Base
{
    public class Pila: MiLista {
        public Pila(): base()
        {
        }

        public void Apilar(int dato) {
            InsertarNodoxPosicion(new Nodo(dato), 0);
        }

        public int? Desapilar() {
            return ObteneryRemoverPrimero()?.dato;
        }
    }
}