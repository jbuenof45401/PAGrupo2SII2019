using System;

namespace _16sept2019_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "hola";
            string s2 = s1;
            s2 = "hi";

            Console.WriteLine(s2);
            Console.WriteLine(s1);
            //string s2 = new string("hola");
            //string s2 = "hola";

            // Console.WriteLine((object)s1 == (object)s2);
            // Console.WriteLine(((object)s1).Equals((object)s2));
            // Console.WriteLine(s1 == s2);
        }
    }
}
