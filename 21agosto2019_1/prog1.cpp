#include <iostream>
using namespace std;

void muestra_mensaje() {
    cout<<"hola!"<<endl;
}

int main() {
    void(*p)() = NULL; //Declarar el apuntador, de tipo apuntador a funcion
    p = &muestra_mensaje; //Asignar la direccion de la funcion al apuntador

    (*p)(); //Invocar la funcion, por medio del apuntador

    return 0;
}