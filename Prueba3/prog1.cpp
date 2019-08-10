#include <iostream>
#include <fstream>
using namespace std;

int main () {
    //mateo
    //sebastian bueno
    //brayan torres -falta 2° punto
    //Estefania
    ifstream rfile;
    char linea[50] = "";

    rfile.open("C:\\Tmp\\Universidad\\Pruebas\\VSCode\\Cpp\\Prueba3\\datos.txt", ios::in);
    while(rfile.getline(linea,50)) {
        cout<<linea<<endl;
    }
    rfile.close();

    return 0;
}