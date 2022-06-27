using System;

namespace C5
{
    class Program
    {
        static void Main(string [] args)
        {
            Point p = new Point(5, 2, 3);
            p.PrintInfo();
            Point p2 = new Point(4, 4, 5);
            p2.PrintInfo();
        }
    }
}
