using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaicMethods
{
    public static class Arithmetic
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public static void RectangleSquare(double a, double b)
        {
            Console.WriteLine(a*b);
        }

        public static void RectanglePerimetar(double a, double b)
        {
            Console.WriteLine(2*a +2*b);
        }
    }
}
