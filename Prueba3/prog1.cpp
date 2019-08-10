#include <iostream>
#include <fstream>
using namespace std;

int main () {
    //mateo
    //sebastian bueno
    //brayan torres -falta 2° punto
    //Estefania, otro cambio 2°
    //Marlon Suarez -falta 3°punto
    //Marlon gamba, 2°
    //Alejandra
    //Hernan Gomez
    ifstream rfile;
    char linea[50] = "";

    rfile.open("C:\\Tmp\\Universidad\\Pruebas\\VSCode\\Cpp\\Prueba3\\datos.txt", ios::in);
    while(rfile.getline(linea,50)) {
        cout<<linea<<endl;
    }
    rfile.close();

    return 0;
}