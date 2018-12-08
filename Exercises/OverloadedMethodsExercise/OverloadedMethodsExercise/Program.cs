using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 1;
            b = 2;
            c = 3;
            addition(a, b, c);

            double x, y, z;
            x = 4.7643;
            y = 5.323;
            z = 6.43423;
            addition(x, y, z);
        }
        static void addition(int a, int b, int c)
        {
            int addab = a + b;
            int addabc = a + b + c;
            Console.WriteLine($"a+b={addab}\na+b+c+{addabc}");
        }
        static void addition(double a, double b, double c)
        {
            double addab = a + b;
            double addabc = a + b + c;
            Console.WriteLine($"x+y={addab}\nx+y+z={addabc}");
        }
    }
}
