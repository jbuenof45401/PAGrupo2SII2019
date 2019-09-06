#include <iostream>
#include <cstring>
#include <cmath>
using namespace std;

struct OrdenCompra {
    int numeroOC;
    char fecha[12];          //Defina aqui: una variable char para la fecha de la OC
    double total;            //Defina aqui: una variable double para el total de la OC
};

struct Proveedor {
    int nit;
    char razonSocial[32];
    int cantOCs;
    OrdenCompra *oc;        //Defina aqui: la variable para las 'Ordenes de Compra' del Proveedor, pueden ser n por Proveedor
};

int main() {
    Proveedor *prov = NULL;
    OrdenCompra *oc = NULL;
    int cantProveedores = 0;
    //4.2.1)
    cout<<"Entre cantidad Proveedores: ";
    cin>>cantProveedores;

    //4.2.2)
    prov = (Proveedor *)calloc(cantProveedores,sizeof(Proveedor));
    for (int i = 0; i < cantProveedores; i++) {
        cout<<"entre NIT para el proveedor ("<<i+1<<"): ";
        cin>>prov[i].nit;
        cin.ignore();
        cout<<"entre Razon Social para el proveedor ("<<i+1<<"): ";
        cin.getline(prov[i].razonSocial,32);
        cout<<"Entre cantidad de OCs para el Proveedor ("<<i+1<<"): ";
        cin>>prov[i].cantOCs;
        oc = (OrdenCompra *)calloc(prov[i].cantOCs,sizeof(OrdenCompra));
        for (int j = 0; j < prov[i].cantOCs; j++)
        {
            cout<<"\tentre el # de la OC: ";
            cin>>oc[j].numeroOC;
            cin.ignore();
            cout<<"\tentre la fecha de la OC: ";
            cin.getline(oc[j].fecha,12);
            cout<<"\tentre el total de la OC: ";
            cin>>oc[j].total;
        }
        prov[i].oc = oc;
    }

    //4.2.3)
    cout<<endl;
    for (int i = 0; i < cantProveedores; i++) {
        cout<<"Mostrando NIT para el proveedor ("<<i+1<<"): "<<prov[i].nit<<endl;;
        cout<<"Mostrando Razon Social para el proveedor ("<<i+1<<"): "<<prov[i].razonSocial<<endl;

        for (int j = 0; j < prov[i].cantOCs; j++)
        {
            cout<<"\tMostrando el # de la OC: "<<prov[i].oc[j].numeroOC<<endl;
            cout<<"\tMostrando la fecha de la OC: "<<prov[i].oc[j].fecha<<endl;
            cout<<"\tMostrando el total de la OC: "<<prov[i].oc[j].total<<endl;
        }
    }

    //4.2.5)
    for (int i=0; i < cantProveedores; i++ ){
        free(prov[i].oc);
        prov[i].oc = NULL;
    }
    free(prov);
    prov = NULL;
    oc = NULL;

    return 0;
}
