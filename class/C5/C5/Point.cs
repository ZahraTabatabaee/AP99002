using System;

public class Point
{
    public Point(int x, int y, int z)
    {
        this.X = x ;
        this.Y = y ;
        this.Z = z ;
    }

    public double DistanceTo(Point other)
    {
        double result = DistanceTo(this,other);
        return result ;        
    }

    public static double DistanceTo(Point m, Point n)
    {
        double a = Math.Pow((m.X-n.X),2);
        double b = Math.Pow((m.Y-n.Y),2);
        double c = Math.Pow((m.Z-n.Z),2);
        double a_DistanceTo = Math.Sqrt(a+b+c);
        return a_DistanceTo;
    }

    public void PrintInfo()
    {
        System.Console.WriteLine("The X is :" + X);
        System.Console.WriteLine("The Y is :" + Y);
        System.Console.WriteLine("The Z is :" + Z);
        System.Console.WriteLine("-----------------");
    }
    public int X;
    public int Y;
    public int Z;
}
public struct PointValue
{
    public PointValue(int x, int y, int z)
    {
        this.X = x ;
        this.Y = y ;
        this.Z = z ;
    }
    public double DistanceTo(PointValue other)
    {
        double result = DistanceTo(this,other);
        return result ;   
    }

    public static double DistanceTo(PointValue m, PointValue n)
    {
        double a = Math.Pow((m.X-n.X),2);
        double b = Math.Pow((m.Y-n.Y),2);
        double c = Math.Pow((m.Z-n.Z),2);
        double a_DistanceTo = Math.Sqrt(a+b+c);
        return a_DistanceTo;
    }

    public void PrintInfo()
    {
        System.Console.WriteLine("The X is :" + X);
        System.Console.WriteLine("The Y is :" + Y);
        System.Console.WriteLine("The Z is :" + Z);
        System.Console.WriteLine("-----------------");
    }
    public int X;
    public int Y;
    public int Z;
}