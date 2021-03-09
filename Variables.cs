using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogDZ
{
    public static class Variables
    {
//1
        public static int SolveEquation1(int a, int b) 
        {          
            int y = ((5 * a + b * b) / (b - a));

            return y;
        }
//2
        public static int[] ReplaceTwoVars(int a, int b)
        {
            int c = 0;
            c = a;
            a = b;
            b = c;

            return new int[] {a, b};
        }
//3
        public static int[] DivideAndFindRemainder(int a, int b)
        {           
            int c = a / b;
            int d = a % b;

            return new int[] {c, d};           
        }
//4
        public static int SolveEquation2(int a, int b, int c)
        {
            int x = ((c - b) / a);
            return x;
        }
//5
        public static int[] PrintEquationOfStraightLine(int y1, int y2, int x1, int x2)
        {
            int a = y2 - y1 / (x2 - x1);
            int b = y1 - a * x1;    
            
            return new int[] {a,b};
        }
    }
}
