using System;
public class Point
{
    public Point(int x, int y)
    {
        MagnitudeComparer = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
        X = x ;
        Y = y ;
    }
    public int X;
    public int Y;  
    public double MagnitudeComparer;
}
public interface IMyComparer<_Type>
{
    bool Compare(_Type a, _Type b);
}
public class PointXComparer : IMyComparer<Point>
{
    public bool Compare(Point p1, Point p2) => p1.X < p2.X;
}

public class PointYComparer : IMyComparer<Point>
{
    public bool Compare(Point p1, Point p2) => p1.Y < p2.Y;
}

public class PointMagnitudeComparer : IMyComparer<Point>
{
    public bool Compare(Point p1, Point p2) => p1.MagnitudeComparer < p2.MagnitudeComparer;
}

public static class PointComparer
{
    public static PointXComparer PointXComparer = new PointXComparer();
    public static PointYComparer PointYComparer = new PointYComparer();
    public static PointMagnitudeComparer PointMagnitudeComparer = new PointMagnitudeComparer();
}
