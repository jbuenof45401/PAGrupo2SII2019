#include <iostream>
#include <cmath>
using namespace std;

int main(int argc, char *argv[]) {
    int *p = (int *)calloc(2,sizeof(int));
    p[0] = 20;
    p[1] = 30;

    cout<<p<<endl;
    p = (int *)realloc(p,100*sizeof(int));
    cout<<p<<endl;
    cout<<"t: "<<p[1]<<endl;

    free(p);
    cout<<p<<endl;

    double d1 = 1.1;
    int i1 = ceil(d1);

    cout<<i1<<endl;

    return 0;
}
