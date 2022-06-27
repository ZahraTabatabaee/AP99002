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
public class PointXComparer
{
    public bool Compare(Point p1, Point p2) => p1.X < p2.X;
}

public class PointYComparer
{
    public bool Compare(Point p1, Point p2) => p1.Y < p2.Y;
}

public class PointMagnitudeComparer
{
    public bool Compare(Point p1, Point p2) => p1.MagnitudeComparer < p2.MagnitudeComparer;
}

public static class PointComparer
{
    public static PointXComparer PointXComparer = new PointXComparer();
    public static PointYComparer PointYComparer = new PointYComparer();
    public static PointMagnitudeComparer PointMagnitudeComparer = new PointMagnitudeComparer();
}
