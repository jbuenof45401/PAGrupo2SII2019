#include <iostream>
using namespace std;

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
    f1(); //101
    f1(); //101

    return 0;
}
