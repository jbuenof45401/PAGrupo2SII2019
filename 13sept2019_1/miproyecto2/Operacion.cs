using System;

namespace miproyecto2
{
    public class Operacion
    {
        ///<summary>
        ///desc:suma 2 enteros
        ///</summary>
        ///<return>
        ///ret:entero, resultado de la suma
        ///</return>
        ///<param name="n1">
        ///1° Entero
        ///</param>
        ///<param name="n2">
        ///2° Entero
        ///</param>
        public static int sumar(int n1, int n2) {
            return (n1 + n2);
        }

        ///<summary>
        ///desc:resta 2 enteros
        ///</summary>
        ///<return>
        ///ret:entero, resultado de la resta
        ///</return>
        ///<param name="n1">
        ///1° Entero
        ///</param>
        ///<param name="n2">
        ///2° Entero
        ///</param>
        public static int restar(int n1, int n2) {
            return (n1 - n2);
        }
    }
}
