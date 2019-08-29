#include <iostream>
#include <cstring>
#include <cmath>
using namespace std;

enum TipoRectangulo { CUADRADO = 0, RECTANGULO = 1};

double obtenerAreaCuadrado(double base, double altura) {
    return (pow(base, 2));
}

double obtenerAreaRectangulo(double base, double altura) {
    return (base * altura);
}

double calcularArea(double(*rectangulogeneral)(double,double),
                    double base, double altura, TipoRectangulo tiporectangulo) {
    double resultado = 0;

    resultado = (*rectangulogeneral)(base,altura);
    switch(tiporectangulo) {
        case CUADRADO:
            //logica cuando sea un cuadrado
            break;
        case RECTANGULO:
            //logica cuando sea un rectangulo
            break;
        default:
            //logica cuando no se de alguno de los anteriores casos
            break;
    }
    
    return resultado;
}

int main() {
    TipoRectangulo opcion = TipoRectangulo::RECTANGULO; //opcion
    double base = 5.0, altura = 10.0;
    double(*wrapper[])(double,double) = {&obtenerAreaCuadrado,&obtenerAreaRectangulo};
    double r = calcularArea(wrapper[opcion],base,altura,opcion);

    cout<<"Area: "<<r<<endl;

    return 0;
}