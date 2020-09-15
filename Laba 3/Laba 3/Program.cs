using System;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            double znam1 = Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a);
            double chisl1 = Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a);

            double y = znam1 / chisl1;

            double z = Math.Tan(3 * a);

            double g = y - z;

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(g);
        }
    }
}
