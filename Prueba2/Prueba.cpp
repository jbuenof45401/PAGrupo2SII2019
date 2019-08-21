#include <iostream>
#include <cstring>
using namespace std;

int f1(int num1, int num2){
    cout<<num1 + num2<<endl;

    return (num1 + num2);
}

void f2(int *p, int s1) {
    //size_t t1 = sizeof(p)/sizeof(*p);
    int t1 = p[-1];
    cout<<*(p+1)<<endl;
}

int sumar(int num1, int num2) {
    return (num1 + num2);
}

int restar(int num1, int num2) {
    return (num1 - num2);
}

int main(){
    int arr1[7] = {10,20,30,40,50,60,70};

    f2(arr1, sizeof(arr1)/sizeof(arr1[0]));

    //int(*p1)(int, int) = &f1;
    //int(*p2[])(int, int) = {&sumar, &restar};

    //(*p1)(100, 200);
    //int r = (*p2[1])(500, 100);

    //cout<<r<<endl;
}
