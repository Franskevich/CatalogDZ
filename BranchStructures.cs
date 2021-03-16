using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BrunchStructures
    {
        //1
        public static int SelectMultiplicationOrDifference(int a, int b)
        {
            if (a != b)
            {
                if (a > b)
                {
                    return a + b;
                }
                else
                {
                    return a * b;
                }
            }
            else
            {
                return a - b;
            }
        }
        //2
        public static int DefineQuarter(int x, int y)
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
        public static int[] SortNumbersInAscending(int a, int b, int c)
        {
            int[] output = new int[3];
            if (a < b && a <= c)
            {
                if (b <= c)
                {
                    return new int[] { a, b, c };
                }
                else
                {
                    return new int[] { a, c, b };
                }
            }
            if (b < a && b <= c)
            {
                if (a <= c)
                {
                    return new int[] { b, a, c };
                }
                else
                {
                    return new int[] { b, c, a };
                }
            }

            if (c < a && c <= b)
            {
                if (a <= b)
                {
                    return new int[] { a, b, c };
                }
                else
                {
                    return new int[] { c, b, a };
                }
            }
            return new int[] { a, b, c };
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
        //5
        public static string NumberInWords(int xy)
        {
            string a = "", b = "";

            switch (xy)
            {
                case 10:
                    return ("десять");
                case 11:
                    return ("одиннадцать");
                case 12:
                    return ("двенадцать");
                case 13:
                    return ("тринадцать");
                case 14:
                    return ("четырнадцать");
                case 15:
                    return ("пятнадцать");
                case 16:
                    return ("шестнадцать");
                case 17:
                    return ("семнадцать");
                case 18:
                    return ("восемнадцать");
                case 19:
                    return ("девятнадцать");
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
                    return ($"{a} {b}");
            }
        }
    }
}
