#include <iostream>
#include <algorithm>
#include <cmath>
using namespace std;

void MostrarCantidadCifrasNumero() {
    /*
    1.pedir el número
    2. En un ciclo, mientras el numero sea mayor a cero:
        3.dividir el número entre 10.
        4.Incremente en un contador.
    5.Imprimir las unidades que tiene el número.   
    */
    int num = 0;
    int aux = 0;

    num = 3;
    while (num > 0){
        num /=10;
        aux += 1;
    }
    cout<<"Las unidades son: "<<aux<<endl;

}

void IndicarCondicionNumeros_9(double num1, double num2, double num3) {
    /*
    Objetivo: a partir de 3 numeros reales, indicar cual fue:
        el menor
        el intermedio
        el mayor
        o iguales
        1. capturo 3 numeros
        2. insertaria en un arreglo
        3. ordernar el arreglo
        4. recorrer el arreglo para mostrar los iguales
        5. mostraria menor, intermedio y mayor        
    */

    //2.
    double nums[3]= {num1, num2, num3};

    //3.
    sort(nums, nums + 3);

    //4.
    if(nums[0] == nums[1] && nums[1] == nums[2]) {
        cout<<"todos los numeros son iguales ("<<nums[0]<<")"<<endl;
    } else if(nums[1] == nums[2]) {
        cout<<"num2 y num3 son iguales ("<<nums[1]<<")"<<endl;
        cout<<", donde el menor es num1 ("<<nums[0]<<")"<<endl;
        cout<<"y el mayor es ("<<nums[1]<<")"<<endl;
    } else if(nums[0] == nums[1]) {
        cout<<"num1 y num2 son iguales ("<<nums[0]<<")"<<endl;
        cout<<", donde el menor es ("<<nums[0]<<")"<<endl;
        cout<<"y el mayor es num3 ("<<nums[2]<<")"<<endl;
    } else {
        cout<<"no hubo iguales!"<<endl;
        cout<<"el menor es: "<<nums[0]<<endl;
        cout<<"el intermedio es: "<<nums[1]<<endl;
        cout<<"el mayor es: "<<nums[2]<<endl;
    }
}

void ConvertirBinarioADecimal() {
    int numbinario[3] = {1,1,1};
    /*
    1. En un ciclo:
    2.  Se va acumulando(sumar) el resultado: DIGITO-DERECHO x(2^i)
    3. mostrar el resultado acumulado
    */
   int i=2;
   int decimal=0;

   while (i >= 0)
   {
       decimal += (numbinario[i]*pow(2,i));
       i--;
   } 
   cout<<"el numero decimal es: "<<decimal<<endl;
}

int main() {
    //4.
    MostrarCantidadCifrasNumero();

    //2.
    //ConvertirBinarioADecimal();

    //#9
    //IndicarCondicionNumeros_9(1,2,2);

    return 0;
}
