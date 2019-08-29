#include <iostream>
using namespace std;

int main() {
    //Reservar 1 partes, cada parte de tamaño int, y apuntar ese bloque con
    //el apunatdor *p
    int *p = (int *)calloc(1,sizeof(int));

    //Asignamos un dato en esa parte
    *(p+0) = 100;

    //Relocalizamos un nuevo espacio de memoria, ahora de 2 partes, cada una de tipo int
    //y el apuntador *P apuntara a ese nueva direccion
    p = (int *)realloc(p,2*sizeof(int));

    *(p+1) = 200; //p[1] = 200;

    cout<<*(p+0)<<endl;
    cout<<*(p+1)<<endl;

    //Liberar todos los espacios de memoria reservados y apuntados por *p
    free(p);
    p = NULL;

    return 0;
}
