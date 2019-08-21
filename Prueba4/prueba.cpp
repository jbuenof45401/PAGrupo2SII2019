#include <iostream>
#include <ctime>
#include <cstring>
using namespace std;

int ObtenerAleatorioEnRango(int infer, int super) {
    int randomico_diferencia = 0;

    randomico_diferencia = super - infer;

    return ((rand() % randomico_diferencia) + infer);
}

void f1() {
    srand(time(NULL));
    int limite = 10;
    int numero_randomico = 0;
    /*La Linea#23, genera un entero randomico, en el rango [0 ~ limite] inclusive
      Ej: limite = 3;
      valores posibles sobre el que se generara el numero randomico:
      0,1,2 o 3
    */
    numero_randomico = rand() % (limite + 1);
    int i = limite;
    cout<<"i: "<<i<<endl;
    cout<<"limite: "<<limite<<endl;
    cout<<"numero_randomico: "<<numero_randomico<<endl;
    while(i >= numero_randomico) {
        i--;
    }
    cout<<"i: "<<i<<endl;
}

void f3(int *p, int *b) {
  p = b;
}

void f3(int **p, int *b) {
  *p = b;
}

void f2() {
  int a = 20;
  int b = 40;
  int *p1 = NULL;
  
  p1 = &a;

  //f3(&p1, &b);
  f3(p1, &b);
  
  *p1 += 1;

  cout<<"r: "<<*p1<<endl;
}

int main() {
    //srand(time(NULL));
    //cout<<ObtenerAleatorioEnRango(0,2)<<endl;
    f1();
    //f2();
}
