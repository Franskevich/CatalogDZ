using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogDZ
{
    class Loops
    {
        //1
        public static int RaiseToDegree(int a, int b)
        {
            int c = a;

            for (int i = 1; i != b; i++)
            {
                c = c * a;
            }
            return c;
        }
        //2
        public static int[] PrintNumbersDivisibleByA(int a)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i < 1000; i += a)

            {
                if (i % a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //3
        public static int[] FindTheNumberOfPositiveIntegersWhoseSquaresAreLessThanA(int a)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i * i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
        //4
        public static int FindTheLargestDivisor(int a)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int i = 2;
            while (a % i != 0)
            {
                i++;
            }
            Console.WriteLine(a / i);
        }
        //5
        public static int[] SumOfNumbersDivisibleBy7(int a, int b)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;

            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    if (i % 7 == 0)
                    {
                        Sum = Sum + i;
                    }
                }
            }
            Console.WriteLine(Sum);
        }
        //6
        public static int PrintTheNumberOfTheFibonacciSeries(int n)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int x1 = 0;
            int x2 = 1;
            int sum = 0;
            {
                for (int i = 1; i < N; i++)
                {
                    sum = x1 + x2;
                    x1 = x2;
                    x2 = sum;
                }
                Console.WriteLine(x2);
            }
        }
        //7
        public static int FindTheGreatestCommonDivisor(int a, int b)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            while (A != 0 && B != 0)
            {
                if (A > B)
                {
                    A = A % B;
                }
                else
                {
                    B = B % A;
                }
            }
            Console.WriteLine(A + B);
        }
        //8
        public static int Find By Binary Search(int n)
        {
            // y = n*n*n
            int y = Convert.ToInt32(Console.ReadLine());

            int left = 0;
            int right = y;
            int middle = right;

            while (y != middle * middle * middle)
            {
                if (middle * middle * middle > y)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
            }

            Console.WriteLine(middle);
        }
        //9
        public static int[] FindTheNumberOfOddDigitsOfANumber(int a)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int odd = 0;
            while (n > 0)
            {
                odd = odd + n % 2;
                n = n / 10;
            }
            Console.WriteLine(odd);
        }
        //10
        public static int[] Find The Mirror Image Of A Number(int a)
        {
            string input = Console.ReadLine();
            string output = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }
        //11
        public static int[] FindNumbersWhoseSumOfEvenDigitsIsGreaterThanTheSumOfOddDigits(int n)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    int a = i;
                    int odd = 0;
                    int even = 0;
                    while (a != 0)
                    {
                        int cifra = a % 10;
                        if (cifra % 2 == 0)
                        {
                            even += cifra;
                        }
                        else
                        {
                            odd += cifra;
                        }
                        a = a / 10;
                    }
                    if (odd < even)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
        //12
        public static string DetermineIfThereAreIdenticalNumbers(int a, int b)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string answer = "net";

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        answer = "da";
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
