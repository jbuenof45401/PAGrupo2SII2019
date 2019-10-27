using System;

namespace _16oct2019_1.Base
{
    public class Cola: MiLista {
        public Cola(): base()
        {
        }

        public void Encolar(int dato) {
            Adicionar(dato);
        }

        public int? Desencolar() {
            return ObteneryRemoverPrimero()?.dato;
        }
    }
}