#include <iostream>
using namespace std;

int sumar(int num1, int num2) {
    return (num1 + num2);
}

int restar(int num1, int num2) {
    return (num1 - num2);
}

int main() {
    int(*p[2])(int,int) = {&sumar,&restar}; //Declarar el apuntador, de tipo apuntador a funcion    
    int r = 0;
    int opcion = 1; //0-sumar,1-restar

    //Avanced Programmer!
    //r = (*p[opcion])(50,20); //Invocar la funcion, por medio del apuntador    

    //Junior-normalito programmer
    cout<<"Es q soy un junior!"<<endl;
    if(opcion == 0) { //cuando vamos a sumar
        r = sumar(50,20);
    } else if(opcion == 1) { //cuando vamos a restar
        r = restar(50,20);
    }
    cout<<r<<endl;

    return 0;
}