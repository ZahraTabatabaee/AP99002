using System;
using System.Collections.Generic;

namespace C10
{
    public class Program
    {
        public static void Sort<_Type>(_Type[] nums, IMyComparer<_Type> comparer)
        {
            for(int i=0; i<nums.Length; i++)
                for (int j=i; j<nums.Length; j++)
                    if (comparer.Compare(nums[i], nums[j]))
                        Swap<_Type>(nums, i, j);
        }
        private static void Swap<_Type>(_Type[] nums, int i, int j)
        {
            _Type temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Main(string[] args)
        {
            Point[] Points = new Point[]{
                new Point(1, 2),
                new Point(2, 4),
                new Point(3, 6),
                new Point(4, 8),
                new Point(5, 10),
                new Point(6, 5),
                new Point(7, 4),
            };

            Sort<Point>(Points, PointComparer.PointXComparer);
            // StudentGPAComparer gpaComparer = new StudentGPAComparer();
            // Sort<Student>(students, gpaComparer);

            //StudentComparer sc = new StudentComparer();

            foreach(Point p in Points)
                System.Console.WriteLine(p.X);
        }
}}

