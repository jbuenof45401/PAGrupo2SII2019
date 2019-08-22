#include <iostream>
using namespace std;

int muestra_mensaje(int a) {
    return (a + 1);
}

int main() {
    int(*p)(int) = NULL; //Declarar el apuntador, de tipo apuntador a funcion
    p = &muestra_mensaje; //Asignar la direccion de la funcion al apuntador
    int b = 0;

    b = (*p)(50); //Invocar la funcion, por medio del apuntador
    cout<<b<<endl;

    return 0;
}