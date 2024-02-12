using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
             double F(double x, int b = 8)
            {
                if (b == 0)
                {
                    return 2;
                }
                else
                    return b * Math.Cos((b - 1) * x) + F(x, --b);
            }

            double X = double.Parse(Console.ReadLine());
            Console.WriteLine(F(X));
        }
    }
}
