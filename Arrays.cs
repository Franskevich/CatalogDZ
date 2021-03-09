using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogDZ
{
    public static class Arrays
    {
        
        Random random = new Random();
        int r = random.Next(1, 20);
        int[] array = new int[r];
            for (int i = 0; i<array.Length; i++)
            {
                array[i] = random.Next(1, 20);
                Console.Write(array[i] + " ");
            }
    int sum = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] % 2 == 0) 
                {
                    sum = sum++;
                }
            }

            Console.WriteLine("\n" + sum);
    }
}
