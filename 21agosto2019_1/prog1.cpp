#include <iostream>
using namespace std;

void copiar(int *p, int *c, int tamano) {
    for (int i = 0; i < tamano; i++)
    {
        c[i] = p[i];
    }
}

void mostrar(int *p, int tamano) {
    for (int i = 0; i < tamano; i++)
    {
        cout<<p[i]<<endl;
    }
}

void f1(int *p) {
    *(p + 1) = 50;
}

int main() {
    int tamano = 3;
    int original[tamano] = {10,20,30};
    int aux[tamano] = {0};

    copiar(original, aux, tamano);
    f1(aux);
    mostrar(original, tamano);

    return 0;
}