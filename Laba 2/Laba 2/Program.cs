using System;

namespace Programms
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            double y = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);

            double skobki1 = (Math.PI / 4) + 2 * a;

            double z = 2 * Math.Sqrt(2) * Math.Cos(a) * Math.Sin(skobki1);

            double g = (y - z);

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(g);

            Console.ReadKey();
        }
    }
}
