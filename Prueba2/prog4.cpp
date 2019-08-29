#include <iostream>
#include <cstring>
using namespace std;

void f1(char *p) {
    strcat(p, " piloso");
}

int main() {
    char c[32] = "Hola companero";

    f1(c);
    cout<<c<<endl;

    return 0;    
}
