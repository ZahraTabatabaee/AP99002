using System;

namespace C6
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int tmp = a ;
            a = b ;
            b = tmp ;
        }
        static void UpdateName(Person p , string newName)
        {
            p.Name = newName ;
        }
        static void UpdateName(PersonV p , string newName)
        {
            p.Name = newName ;
        }


        static void Main(string[] args)
        {
            // Person p = new Person {Name="Ali", Id=99521415};
            // UpdateName(p,"hoshang"); //avaz shod -> reference type
            // PersonV pv = new PersonV {Name = "Alexandra", Id = 52141516};
            // UpdateName(pv,"zahra"); //avaz nashod -> value type
            // // to static nemitonestim this bezarim
            Point p = new Point{X=2,Y=3};
            Shape s = new Shape("triangle",3);
            s.UpdateCorner(0,p); //(2,3)
            p.X = 3;
            s.UpdateCorner(1,p); //(3,3)
            p.Y = 6;
            s.UpdateCorner(2,p); //(3,6)
            s.PrintCorners();
        }


        // static void Main1(string[] args)
        // {
        //     int a = 5;
        //     int b = 7 ;
        //     swap(ref a, ref b);
        //     Console.WriteLine($"a: {a}, b: {b}");
        //     Console.WriteLine("a: "+ a +" b: "+ b );
        //     Console.WriteLine($"a: {0}, b: {1}" , a,b);

        //     Console.WriteLine("Hello World!");
        // }
    }
}
