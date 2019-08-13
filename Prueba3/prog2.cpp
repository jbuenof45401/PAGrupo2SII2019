#include <iostream>
#include <cstdlib>
#include <ctime>
#include <algorithm>
using namespace std;

void ArmarDobleNumeros_10(int num1, int num2, int num3) {
    int num = 0;

    num = (num1 * 100) + (num2 * 10) + num3;
    num *= 2;

    cout<<num<<endl;        
}

void IndicarPosicionNumero_9(double num1, double num2, double num3) {
    double nums[3] = {num1, num2, num3};

    sort(nums, nums + 3);
    cout<<"menor: "<<nums[0]<<endl;
    cout<<"intermedio: "<<nums[1]<<endl;
    cout<<"mayor: "<<nums[2]<<endl;
}

bool EsPar_6(int num) {   

    return (num % 2 == 0);
}

int ObtenerCantidadCifras_5(int num) {
    int cifras = 1;

    while(num >= 10) {
        num = num / 10;
        cifras++;
    }

    return cifras;
}

int ObtenerRandom_4(int num1, int num2) {
    srand(time(NULL));
    int rnum = -1;
    int dif = num2 - num1;

    dif = num2 - num1;
    if(num1 >= 0 && num2 > 0 && dif > 0) {
        rnum = std::rand() % (dif + 1); // rand() return a number between ​0​ and RAND_MAX
        rnum = rnum + num1;
    }

    return rnum;
}

int main () {
    //#10
    //ArmarDobleNumeros_10(1,2,3);

    //#9
    //IndicarPosicionNumero_9(6,9,15);

    //#6
    //cout<<EsPar_6(8)<<endl;

    //#5
    //cout<<ObtenerRandom_4(0,1)<<endl;

    //#4
    //cout<<ObtenerCantidadCifras_5(2)<<endl;

    return 0;
}
