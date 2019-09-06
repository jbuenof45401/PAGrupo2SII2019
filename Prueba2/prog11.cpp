#include <iostream>
#include <stdlib.h>
using namespace std;

int main() {
    //d1=2 y d2=3
    int arr1[3][2] = {
        {10,20},
        {30,40},
        {50,60}
    };
    cout<<arr1[2][1]<<endl; //60

    int d1=2, d2=3;
    int **arr2 = (int **)calloc(d2, sizeof(int *)); 
    for(int i=0; i<d2; i++) 
         *(arr2 + i) = (int *)calloc(d1, sizeof(int));
    
    for(int i=0; i<d2; i++) {
        free(*(arr2+i));
        (*(arr2+i))=NULL;
    }
    free(arr2);
    arr2=NULL;

    return 0;
}
