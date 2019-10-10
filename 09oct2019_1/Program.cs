using System.Xml.Linq;
using System.Linq;
using System;
using System.Collections.Generic;

namespace _09oct2019_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ejemplo que valida que efectivamente ahora 2 objetos con los mismos valores son iguales
            //Console.WriteLine($"{new Cliente(100,"oskr100").Equals(new Cliente(100,"oskr100"))}");
            
            //Dictionary_SortedList();
            List();
        }

        private static void List() {
            /*
                * List es una coleccion de tipo IList
                * Permite objetos repetidos
                * No mantiene los elementos ordenados, NO es de alto desempeño en las busquedas
            */
            //Declara variable referencia de tipo List
            List<Cliente> clientes = null;
            //Crea instancia
            clientes = new List<Cliente>();

            //Añade 2 elementos
            clientes.Add(new Cliente(10,"oscar10"));
            clientes.Add(new Cliente(20,"oscar20"));

            //Muestra si existe un objeto completo de tipo Cliente con nit=20 y nombre="oscar20"
            //Console.WriteLine(clientes.Contains(new Cliente(20,"oscar20")));
            //Muestra si existe al menos un objeto con nombre="oscar20"
            //Console.WriteLine(clientes.Exists(x => x.nombre.Equals("oscar20")));
            //Obtiene un objeto de tipo Cliente con nombre="oscar20"
            //Cliente c = clientes.Where(x => x.nombre.Equals("oscar20")).FirstOrDefault();
            //Actualiza el nombre de aquellos o aquel objeto de tipo Cliente con nombre="oscar20"
            //clientes.Where(x => x.nombre.Equals("oscar20")).Select(x => { x.nombre = "oscar200"; return x; }).ToList();
            //Remueve todos aquellos objetos de tipo Cliente con nombre="oscar20"
            //clientes.RemoveAll(x => x.nombre.Equals("oscar20"));
            
            //Itera la List, y va mostrando cada objeto
            foreach (Cliente i in clientes)
            {
                Console.WriteLine(i);
            }
        }

        private static void Dictionary_SortedList() {
            /*
                * SortedList es una coleccion de tipo IDictionary
                * No permite Keys repetidos, levanta excepcion.
                * Mejor desempeño en las busquedas.
            */
            //Declara variable referencia de tipo SortedList
            //la Key es de tipo int, el Value es de tipo Cliente
            SortedList<int,Cliente> col1 = null;

            //Crea instancia
            col1 = new SortedList<int, Cliente>();

            //Añade 2 elementos, con llave y valor
            col1.Add(5,new Cliente(10,"oscar10"));
            col1.Add(1,new Cliente(20,"oscar20"));
            //Muestra si existe un elemento con Key=10
            //Console.WriteLine(col1.ContainsKey(10));
            //Muestra si existe un elemento con Value=de tipo Cliente con nit=20 y nombre="oscar20"
            //Console.WriteLine(col1.ContainsValue(new Cliente(20,"oscar20")));
            //Muestra si existe un elemento con Value de Cliente con nombre="oscar20"
            //Console.WriteLine(col1.Any(x => x.Value.nombre.Equals("oscar20")));
            //Obtiene un objeto de tipo Cliente con nit=20 y nombre="oscar20"
            //Cliente c = col1.Where(x => x.Value.Equals(new Cliente(20,"oscar20"))).FirstOrDefault().Value;

            //Remueve el elemento con Key=1
            //col1.Remove(1);

            //Con programacion funcional,
            //actualiza el nombre de un elemento que en su Value tenga un objeto de tipo Cliente
            //con nit=20 y nombre="oscar20"
            col1.Where(x => x.Value.Equals(new Cliente(20,"oscar20")))
                .Select(x => {x.Value.nombre = "oscar200"; return x;})
                .ToList();

            //Itera la SortedList, y va mostrando por cada elemento su Key y su Value
            foreach (KeyValuePair<int,Cliente> i in col1)
            {
                Console.WriteLine($"Llave:{i.Key} Valor:{i.Value}");
            }
        }
    }
}
