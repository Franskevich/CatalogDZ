using System;

namespace CatalogDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[] x = Variables.ReplaceTwoVars(a, b);

            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
        }
        {

        }
        
    }
}
