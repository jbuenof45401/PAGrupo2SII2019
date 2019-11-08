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

        protected bool EstaVacia() {
            return (p==null && u==null);
        }

        protected void Adicionar(int dato) {
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
        protected void RemoverPrimero() {
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

        protected Nodo ObteneryRemoverPrimero() {
            Nodo nodoCopia = null;

            if(!EstaVacia()) {
                nodoCopia = new Nodo(p.dato);
                RemoverPrimero();
            }

            return nodoCopia;
        }

        protected void InsertarNodoxPosicion(Nodo nodo, int posi) {
            //TODO: Implementar y presentar en la sesion del Viernes 25Oct6Pm
            Nodo nodoAux = null;
            int i = 0;

            if(nodo==null)
                throw new Exception($"el nodo no puede ser null.");
            if((posi<0 || posi>tamano) || (EstaVacia() && posi!=0))
                throw new Exception($"posicion:{posi} NO valida, el tamano:{tamano}.");

            if(EstaVacia() && posi==0) {
                p = nodo;
                u = nodo;
            } else if(!EstaVacia()) {
                if(posi==0) { //Nuevo Primero
                    nodo.sgte = p;
                    p = nodo;                    
                } else if(posi == tamano) { //Nuevo Ultimo
                    u.sgte = nodo;
                    u = nodo;
                } else { //Intermedio
                    nodoAux = p;
                    i = 0;
                    while(i < (posi-1)) {
                        nodoAux.sgte = nodoAux;
                    }                    
                    nodo.sgte = nodoAux.sgte;
                    nodoAux.sgte = nodo;
                }
            }
            tamano += 1;
        }
    }
}
