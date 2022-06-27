using System;

namespace L2
{
    class Program
    {
        public static void Dead(Fighter f1 , Fighter f2)
        {
            System.Console.WriteLine($"{f1.Name} -> WON!");
        }
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter("f1",50);
            Fighter f2 = new Fighter("f2",60);
            f1.GameOver += Dead ;
            f2.GameOver += Dead ;
            while(true)
            {
                f1.attack(f2);
                f2.attack(f1);
                System.Console.WriteLine($"{f1.Name}:{f1.Health} | {f2.Name}:{f2.Health}");
            }
        }
    }
}
