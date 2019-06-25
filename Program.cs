using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parental p1 = new Parental("Bob");
            System.Console.WriteLine(p1.Order);
            p1.Order = 7;
            System.Console.WriteLine(p1.Order);
            p1.Order = 12;
            System.Console.WriteLine(p1.Order);
            ChildHopper c1 = new ChildHopper("Sarah");
            c1.move();
            System.Console.WriteLine(c1.distance);
            System.Console.WriteLine(c1.hop());
            System.Console.WriteLine(c1.EarCount);
            c1.EarCount = 4;
            System.Console.WriteLine(c1.EarCount);
        }
    }
}
