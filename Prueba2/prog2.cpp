#include <iostream>
using namespace std;

void f1(int *p, int i) {
    p = &i;
}

void f2(int **p, int i) {
    *p = &i;
}

int main() {
    int a = 100;
    int *p = NULL;

    p = &a;
    f1(p,30);
    cout<<"1er Caso: "<<*p<<endl;    
    f2(&p,30);
    cout<<"2do Caso: "<<*p<<endl;

    return 0;
}