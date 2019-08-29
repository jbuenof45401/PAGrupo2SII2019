#include <iostream>
#include <cstring>
using namespace std;

void f1(int (*p)[2][3]) {
    //cout<<*(*(*p)+8)<<endl;
    //cout<<*(*(*(p+1)+1)+1)<<endl;
    cout<<p[1][0][0]<<endl;
    //cout<<*(*(*p)+8)+5<<endl;
}

int main() {
    int n[2][2][3] = {
        {
            {10,20,30},
            {40,50,60}
        },
        {
            {70,80,90},
            {100,110,120}
        }
    };

    f1(n);

    return 0;    
}
