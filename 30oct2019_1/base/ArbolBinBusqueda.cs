using System;

namespace _30oct2019_1
{
    public class ArbolBinBusqueda {
        public Nodo raiz;

        public ArbolBinBusqueda()
        {
            this.raiz = null;            
        }

        public bool EstaVacio() {
            return (raiz==null);
        }

        public void Insertar(Nodo nodo) {
            Nodo nodoAux = null;

            if(nodo==null)
                throw new Exception("el nodo es NULL");

            if(EstaVacio()) {
                raiz = nodo;
            } else {
                nodoAux = raiz;
                while(true) {
                    if(nodo.dato < nodoAux.dato) {
                        if(nodoAux.izq!=null)
                            nodoAux = nodoAux.izq;
                        else {
                            nodoAux.izq = nodo;
                            break;
                        }
                    } else if(nodo.dato > nodoAux.dato) {
                        if(nodoAux.der!=null)
                            nodoAux = nodoAux.der;
                        else {
                            nodoAux.der = nodo;
                            break;
                        }
                    } else { //ya habia sido insertado
                        throw new Exception($"El nodo cond dato:{nodo.dato} ya habia sido insertado!");
                    }
                }
            }
        }
    
        public bool ExisteNodo(int dato) {
            Nodo nodo = null;
            Nodo nodoAux = null;

            nodo = new Nodo(dato);
            if(EstaVacio()) {
                return false;
            } else {
                nodoAux = raiz;
                while(true) {
                    if(nodo.dato==nodoAux.dato)
                        return true;
                    else if(nodo.dato<nodoAux.dato && nodoAux.izq!=null) {
                        nodoAux = nodoAux.izq;                        
                    }
                    else if(nodo.dato>nodoAux.dato && nodoAux.der!=null) {
                        nodoAux = nodoAux.der;
                    }
                    else {
                        return false;
                    }
                }
            }
        }
    }
}
