using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Loops
    {
        //1
        public static int RaiseToDegree(int a, int b)
        {
            int c = a;

            for (int i = 1; i != b; i++)
            {
                c *= a;
            }
            return c;
        }
        //2
        public static void PrintNumbersDivisibleByA(int a)
        {
            for (int i = a; i < 1000; i += a)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //3
        public static void FindTheNumberOfPositiveIntegersWhoseSquaresAreLessThanA(int a)
        {
            for (int i = 1; i * i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
        //4
        public static int FindTheLargestDivisor(int a)
        {
            int i = 2;
            while (a % i != 0)
            {
                i++;
            }
            return (a / i);
        }
        //5
        public static int SumOfNumbersDivisibleBy7(int a, int b)
        {
            int Sum = 0;

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        Sum += i;
                    }
                }
            }
            return Sum;
        }
        //6
        public static int PrintTheNumberOfTheFibonacciSeries(int n)
        {
            int x1 = 0;
            int x2 = 1;
            int sum = 0;
            {
                for (int i = 1; i < n; i++)
                {
                    sum = x1 + x2;
                    x1 = x2;
                    x2 = sum;
                }
                return x2;
            }
        }
        //7
        public static int FindTheGreatestCommonDivisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }
        //8
        public static int FindByBinarySearch(int n)
        {
            // y = n*n*n
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
            return middle;
        }
        //9
        public static int FindTheNumberOfOddDigitsOfANumber(int n)
        {
            int odd = 0;
            while (n > 0)
            {
                odd += n % 2;
                n /= 10;
            }
            return odd;
        }
        //10
        public static int[] FindTheMirrorImageOfANumber(int a)
        {
            string input = Console.ReadLine();
            string output = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return new int[](output);
        }
        //11
        public static int FindNumbersWhoseSumOfEvenDigitsIsGreaterThanTheSumOfOddDigits(int n)
        {
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
                return count;
            }
        }
        //12
        public static int[] DetermineIfThereAreIdenticalNumbers(int a, int b)
        {
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
            return answer;
        }
    }
}
