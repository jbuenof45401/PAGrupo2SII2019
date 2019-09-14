using System;

namespace _13sept2019_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Multidimensional
            int[,] arr2 = new int[2,3] {
                {10,20,30},
                {40,50,60}
            };            
            //Console.WriteLine(arr2[1,1]);
            foreach(int i in arr2) {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    //Console.WriteLine(arr2[i,j]);
                }
            }

            //Jagged
            int[][] arr1 = new int[2][] {
                new[] {10,20,30},
                new[] {40,50,60},
            };
            //Console.WriteLine(arr1[1][1]);
            foreach(int[] d1 in arr1) {
                foreach(int d2 in d1) {
                    //Console.WriteLine(d2);
                }
            }
        }

        public static void EjemploPrecedenciaOperadores(string[] args)
        {
            /*
            Precedence:
                (),[],++,--
                *,/,%
                +,-
                ?:
            */
            int i = 10;
            int r = 5 * (10 + 20) + i++ / 10 + i;            
            Console.WriteLine(r);            
        }
    }
}
