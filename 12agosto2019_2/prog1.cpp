#include <iostream>
using namespace std;

void f1(int a) {
    a = a + 1;
}

void f2(int b[]) {
    b[0] = b[0] + 1;
}

int main() {
    int a = 10;
    int b[1] = {};
    b[0] = 20;

    f1(a);
    cout<<a<<endl; //Federico:11;Miguel:11

    f2(b);
    cout<<b[0]<<endl; //Federico:21;Miguel:21
}
