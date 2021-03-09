using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogDZ
{
    public static class BranchStructures
    {
        //1
        public static int MultiplyOrAdd(int a, int b)
        {
            if (a > b)
            {
                return a * b;
            }
            else
            {
                return a + b;
            }

        }
        //2
        public static int DetermineWhichQuaterPointBelongs(int x, int y)
        {
            if (x > 0)
            {
                if (y < 0)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (y < 0)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
        //3
        public static int[] OutputInAscendingOrder(int A, int B, int C)
        {         
            if (A < B && A <= C)
            {
                if (B <= C)
                {
                    return new int[] {A,B,C};                   
                }
                else
                {
                    return new int[] {A,C,B};                        
                }
            }
            if (B < A && B <=C)
            {
                if (A <= C)
                {
                    return new int[] {B,A,C};                   
                }
                else
                {
                    return new int[] {B,C,A};                   
                }
            }

            if (C < A && C <= B)
            {
                if (A <= B)
                {
                    return new int[] {C,A,B};
                }
                else
                {
                    return new int[] {C,B,A};
                }
            }
            else
            {
                return new int[] { A, B, C };
            }
        }
        //4
        public static class SolveQuadraticEquation
        {
            public static double[] Solve(double a, double b, double c)
            {
                if (a == 0)
                {
                    throw new Exception("a==0");
                }

                double d = SolveQuadraticEquation.FindD(a, b, c);
                if (d > 0)
                {
                    return FindTwoX(a, b, d);
                }
                else if (d == 0)
                {
                    return FindOneX(a, b);
                }
                else
                {
                    return FindZeroX();
                }
            }
            private static double FindD(double a, double b, double c)
            {
                return b * b - 4 * a * c;
            }
            private static double[] FindOneX(double a, double b)
            {
                if (a == 0)
                {
                    throw new Exception("a==0");
                }
                double x = (-b) / (2 * a);
                return new double[] { x };
            }
            private static double[] FindTwoX(double a, double b, double d)
            {
                if (a == 0)
                {
                    throw new Exception("a==0");
                }
                if (d < 0)
                {
                    throw new Exception("d<0");
                }
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
            private static double[] FindZeroX()
            {
                return new double[0];
            }
        }
        public static string[] PrintNumberInWords ()
        {            
            string a = "", b = "";

            switch (xy)
            {
                case 10:
                    Console.WriteLine("десять");
                    break;
                case 11:
                    Console.WriteLine("одиннадцать");
                    break;
                case 12:
                    Console.WriteLine("двенадцать");
                    break;
                case 13:
                    Console.WriteLine("тринадцать");
                    break;
                case 14:
                    Console.WriteLine("четырнадцать");
                    break;
                case 15:
                    Console.WriteLine("пятнадцать");
                    break;
                case 16:
                    Console.WriteLine("шестнадцать");
                    break;
                case 17:
                    Console.WriteLine("семнадцать");
                    break;
                case 18:
                    Console.WriteLine("восемнадцать");
                    break;
                case 19:
                    Console.WriteLine("девятнадцать");
                    break;
                default:
                    switch (xy / 10)

                    {
                        case 2:
                            a = "двадцать";
                            break;
                        case 3:
                            a = "тридцать";
                            break;
                        case 4:
                            a = "сорок";
                            break;
                        case 5:
                            a = "пятьдесят";
                            break;
                        case 6:
                            a = "шестьдесят";
                            break;
                        case 7:
                            a = "семьдесят";
                            break;
                        case 8:
                            a = "восемьдеся";
                            break;
                        case 9:
                            a = "девяносто";
                            break;
                    }

                    switch (xy % 10)

                    {
                        case 0:

                            break;
                        case 1:
                            b = "один";
                            break;
                        case 2:
                            b = "два";
                            break;
                        case 3:
                            b = "три";
                            break;
                        case 4:
                            b = "четыре";
                            break;
                        case 5:
                            b = "пять";
                            break;
                        case 6:
                            b = "шесть";
                            break;
                        case 7:
                            b = "семь";
                            break;
                        case 8:
                            b = "восемь";
                            break;
                        case 9:
                            b = "девять";
                            break;
                    }
                    Console.WriteLine($"{a} {b}");
                    break;
            }
        }
    }
}
