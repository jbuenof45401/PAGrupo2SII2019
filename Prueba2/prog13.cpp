#include <iostream>
#include <stdlib.h>
using namespace std;

void f1(int (*p)[3][2]) {
    cout<<*(*(*(p+0)+0)+8)<<endl;
}

int main() {
    int arr1[2][3][2] = {
        {
            {10,20},
            {30,40},
            {50,60}
        },
        {
            {70,80},
            {90,100},
            {1100,1200}
        }
    };
    f1(arr1);
}
