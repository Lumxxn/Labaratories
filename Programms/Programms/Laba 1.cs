using System;

namespace Programms
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double scobki1 = ((Math.PI / 2) + (3 * a));
            double skobki2 = ((3 * a) - Math.PI);

            double chisl1 = Math.Sin(scobki1);
            double znam1 = 1 - Math.Sin(skobki2);
            double y = chisl1 / znam1;
            Console.WriteLine(y);

            // double scobki2 = (((5 / 4) * Math.PI) + ((3 / 2) * a));
            double scobki2 = ((5*Math.PI/4) + (3 * a /2));
            double z = 1 / Math.Tan(scobki2);

            double g = (y) - (z);
            Console.WriteLine(z);
            Console.WriteLine(g);
        }
    }
}   
