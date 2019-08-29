#include <iostream>
using namespace std;

int i1 = 10;
const int i2 = 0;

void f1() {
    static int i = 100;

    i += 1;
    cout<<i<<endl;
}

void f2() {
    static int i = 100;

    i += 1;
    cout<<i<<endl;
}

int main() {
    f1();
    f2();
    f1();
    f2();
    int i;

    cout<<i<<endl;

    return 0;    
}
