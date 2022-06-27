using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public record Point(double x, double y);

public static class QExt
{    
    public static double Q01EuclideanDistance(Point p1, Point p2) => Math.Sqrt(Math.Pow(p1.x-p2.x,2)+Math.Pow(p1.y-p2.y,2));

    public static double Q02ManhatanDistance(Point p1, Point p2) => Math.Abs(p1.x-p2.x)+Math.Abs(p1.y-p2.y);

    public static double Q03StringDistance(string s1, string s2)
    {
        // double result = 0 ;
        string s = "";
        for(int i = 0 ; i < s1.Length ; i++)
        {
            for(int j = 0 ; j < s2.Length ; j++)
            {
                if(s1[i]==s2[j])
                {
                    s += s1[i];
                }
                
            }
        }
        return s1.Length-s.Length ;
    }

    public static (int min, int max) Q11GetRange(this int[] nums)
    {
        if(nums == null)
            throw new InvalidOperationException();
        return (nums.Min(),nums.Max());
    }

    public static int Q12GetRange(this int[] nums) => nums.Max()-nums.Min();

    public static (T min, T max) Q13GetRange<T>(this T[] vals) where T: IComparable<T> => (vals.Min(),vals.Max());

    public static (T min, T max) Q14GetRange<T>(this T[] vals, Func<T, T, double> diff)
    {
        T max = default;
        T Min = default;
        double Max = 0 ;
        foreach (var first in vals)
        {
            foreach (var second in vals)
            {
                if(diff(first,second)>Max)
                {
                    Max = diff(first,second);
                    max = first ;
                    Min = second ;
                }
            }
        }
        return (Min , max);

    }

    public static double Q15GetRange<T>(this T[] vals, Func<T, T, double> diff)
    {
        double Max = 0 ;
        foreach (var first in vals)
        {
            foreach (var second in vals)
            {
                if(diff(first,second)>Max)
                {
                    Max = diff(first,second);
                }
            }
        }
        return Max ;
    }
}