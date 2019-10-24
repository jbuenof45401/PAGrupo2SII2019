using System;

namespace _16oct2019_1.Base
{
    public class MiLista
    {
        Nodo p;
        Nodo u;
        int tamano;

        public MiLista()
        {
            p = null;
            u = null;
            tamano = 0;            
        }

        public bool EstaVacia() {
            return (p==null && u==null);
        }

        public void Adicionar(int dato) {
            Nodo nodo = new Nodo(dato);
            if(EstaVacia()) {
                p = nodo;
                u = nodo;
            } else {
                u.sgte = nodo;
                u = nodo;
            }
            tamano +=1;
        }

        public void Mostrar() {
            Nodo nodoAux = null;
            int i=0;

            nodoAux = p;
            while(i++ < tamano) {
                Console.WriteLine(nodoAux.dato);
                nodoAux = nodoAux.sgte;
            }
        }

        public void RemoverPrimero() {
            Nodo nodoAux = null;

            if(!EstaVacia()) {
                if(tamano == 1) {
                    p = null;
                    u = null;
                } else { // por lo menos hay 2 nodos
                    nodoAux = p;
                    p = p.sgte;
                    nodoAux.sgte = null;                                        
                }
                tamano -= 1;
            }
        }

        public Nodo ObteneryRemoverPrimero() {
            Nodo nodoCopia = null;

            if(!EstaVacia()) {
                nodoCopia = new Nodo(p.dato);
                RemoverPrimero();
            }

            return nodoCopia;
        }

        public void InsertarNodoxPosicion(Nodo nodo, int posi) {
            //TODO: Implementar y presentar en la sesion del Viernes 25Oct6Pm
        }
    }
}
