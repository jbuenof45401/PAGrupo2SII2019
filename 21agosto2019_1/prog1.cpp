#include <iostream>
using namespace std;

void f1(int *p1) {
    *(p1 + 1) = 50;
    cout<<p1[1]<<endl; //notacion arreglo
    cout<<*(p1 + 1)<<endl; //notaion de apuntador
}

int main() {
    int arr1[3] = {10,20,30};

    f1(arr1);

    return 0;
}