using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogDZ
{
    public static class Arrays
    {
        //1
        public static int FindMinNumber(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        //2
        public static int FindMaxNumber(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        //3
        public static int FindIndexOfMin(int[] array)
        {
            int min = array[0];
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        //4
        public static int FindIndexOfMax(int[] array)
        {
            int max = array[0];
            int IndexOfMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    IndexOfMax = i;
                }
            }
            return IndexOfMax;
        }
        //5
        public static int CalculateSumOfOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + array[i];
                }
            }
            return sum;
        }
        //6
        public static int[] ArrayReverse(int[] array)
        {
            int d = array.Length;
            int tmp;
            for (int i = 0; i < d / 2; i++)
            {
                tmp = array[i];
                array[i] = array[d - i - 1];
                array[d - i - 1] = tmp;
            }
            return array;
        }
        //7
        public static int CountOddElementsOfArray(int[] array)
        {
            int counterOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    counterOdd++;
                }
            }
            return counterOdd;
        }
        //8
        public static int[] ChangeHalves(int[] array)
        {
            int d = array.Length;
            int count1 = 0;
            int count2 = d / 2;
            while (count1 < d / 2)
            {
                int tmp = array[count1];
                array[count1] = array[count2];
                array[count2] = tmp;

                count1++;
                count2++;
            }

            return array;
        }
        //9
        public static int[] SortInAscendingOrder(int[] array)
        {
            int tmp;
            int d = array.Length;
            for (int j = 0; j < d; j++)
            {
                for (int i = 0; i < d - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }
            return array;
        }
        //10
        public static int[] SortInDescendingOrder(int[] array)
        {
            int min;
            int tmp = 0;
            int d = array.Length;
            for (int i = 0; i < d - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < d; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;
                    }
                    tmp = array[i];
                    array[i] = array[min];
                    array[min] = tmp;
                }
            }
            return array;
        }
        //1.1
        public static int FindMinNumb(int[,] arr)
        {
            int minElement = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElement > arr[i, j])
                    {
                        minElement = arr[i, j];
                    }
                }
            }
            return minElement;
        }
        //1.2
        public string int[,] FindMaxNumb(int[,] arr)
        {
            int[,] array = new int[5, 5];
            InitializeArray(array);
            Console.WriteLine();

            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }

                }

            }
            Console.WriteLine("Максимальный элемент: " + max);
            Console.ReadLine();
        }
        //1.3
        public string int[,] FindIndexOfMin(int[,] arr)
        {
            int[,] array = new int[5, 5];
            InitializeArray(array);
            Console.WriteLine();
            int min = array[0, 0];
            int x = 0, y = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        x = i;
                        y = j;
                    }

                }

            }
        }
        //1.4
        public string int[,] FindIndexOfMax(int[,] arr)
        {
            int[,] array = new int[5, 5];
            InitializeArray(array);
            Console.WriteLine();
            int max = array[0, 0];
            int x = 0, y = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        x = i;
                        y = j;
                    }

                }

            }

            Console.WriteLine("[{0},{1}]", x, y);
        }
        //1.5
        public string int[,] FindNumberOfArrayElementsThatLargerThanAllTheirNeighbors(int[,] arr)
        {
            int[,] array = new int[5, 5];
            InitializeArray(array);
            Console.WriteLine();
            CountEllementsWitchGreatAllNumbers(array);

        }

        public static int CountEllementsWitchGreatAllNumbers(int[,] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i <= 0 || arr[i, j] > arr[i - 1, j])
                        && (i >= arr.GetLength(0) - 1 || arr[i, j] > arr[i + 1, j])
                        && (j <= 0 || arr[i, j] > arr[i, j - 1])
                        && (i <= arr.GetLength(1) - 1 || arr[i, j] > arr[i, j + 1]))
                    {
                        counter++;
                        Console.WriteLine($"{arr[i, j]} i={i}, j={j}");
                    }
                }
            }

            return counter;
        }

        static void InitializeArray(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1000);
                    Console.Write("[{0},{1}] = {2} ", i, j, array[i, j]);
                }
                Console.WriteLine();
            }
        }
        //1.6
        public string int[,] ReflectTheArrayRelativeToItsMainDiagonal(int[,] arr)
        {
            int[,] A = new int[5, 5];
            InitializeArray(A);
            Console.WriteLine();

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = i + 1; j < A.GetLength(1); j++)
                {
                    var tmp = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = tmp;
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}] = {2} ", i, j, A[i, j]);
                }
                Console.WriteLine();
            }

        }

        static void InitializeArray(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1000);
                    Console.Write("[{0},{1}] = {2} ", i, j, array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
