#include <iostream>
using namespace std;

void f1(int **p) {
    static int a = 100;
    cout<<&a<<endl;
    *p = &a;
}

int main() {
    int *p = NULL;
    f1(&p);
    cout<<p<<endl;
    cout<<*p<<endl;

    return 0;
}
