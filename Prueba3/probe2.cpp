#include <iostream>

using namespace std;

int main(){
    /*
    Objetivo: capturar del usuario un numero entero y mostrar
    descendentemente cada numero hasta 0 (inclusive).
        1. Declarar una variable entera: num
        2. Capturar num
        3. En un for desde num hasta 0:
            4. mostrar la variable iteradora i.
     */
    int num = 0;
    cout<<"introduzca un numero: ";
    cin>>num;
    for (int i = num ; i >= 0 ; i--)
    {
        cout<<i<<endl;   
    }

    return 0;
}