using System;
public class Shape
{
    public Shape(string name, int cornerCount)
    {
        Corners = new Point[cornerCount];
    }

    public void UpdateCorner(int i, Point p)
    {
        Corners[i].X = p.X ;
        Corners[i].Y = p.Y ;
    }

    public Point GetCorner(int i)
    {
        return Corners[i];
    }

    public void SwitchXY(ref Point p)
    {
        int tmp = p.X ;
        p.X = p.Y ;
        p.Y = tmp ;
    }

    public void ExchangeCorners(int i, int j)
    {
        Point N = Corners[i];
        Corners[i] = Corners[j];
        Corners[j] = N ;
    }

    public void PrintCorners()
    {
        for(int i = 0 ; i < Corners.Length ;i++)
        {
            Console.WriteLine("corner[{0}] -> X = {1} , Y = {2}", i, Corners[i].X ,Corners[i].Y);
        }
    }

    private Point[] Corners;

}
