using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace C20
{
    class Student
    {

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;
            if (other != null)
                return this.Name.Equals(other.Name) && this.Id.Equals(other.Id);
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Id.GetHashCode();            
        }

        public override string ToString()
        {
            return this.Name.ToString() + " " + this.Id.ToString();
        }

        public string Name {get; set;}
        public int Id {get; set;}

        public static Student ReadFromConsole()
        {
            System.Console.Write("Name? ");
            string name = Console.ReadLine();
            System.Console.Write("Id? ");
            int id = int.Parse(Console.ReadLine());
            return new Student(name, id);
        }
    }
    static class Ext
    {
        public static void WriteToConsole<_Type>(this _Type[] nums)
        {
            System.Console.WriteLine(string.Join(",", nums));
        }

        public static void MyForEach<_Type>(this _Type[] values, Action<_Type> action)
        {
            foreach(var v in values)
                action(v);
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            string w = "test";
            string w1 = w.ToUpper();
            int len = w1.Length;
            int mylen = w.ToUpper().Length;

            var item = 
            File.ReadLines(@"ChildMortality.csv")
                .Skip(2)
                .Select(s => {
                    var toks = s.Split(',').Select(t => t.Trim(new char[]{'\"', ' '})).ToArray(); ///trim => hazf "
                    return new {
                        Country = toks[0], 
                        Year = int.Parse(toks[1]),
                        Both = double.Parse(toks[2].Split(' ')[0])
                    };
                })
                .Where(d => d.Country.StartsWith("Iran"))//2
                .Aggregate( (d1, d2) => d1.Both > d2.Both ? d1 : d2);//1

            System.Console.WriteLine($"{item.Country} - {item.Year} - {item.Both}");
            // foreach(var i in item)
            //     System.Console.WriteLine($"{i.Country} - {i.Year} - {i.Both}");

        }

        static void Main5(string[] args)
        {
            int[] nums = new int[]{2, 3, 5, 4, 7, 9};
            nums.WriteToConsole();
            // Ext.WriteToConsole(nums);
            string[] names = new string[]{"ali", "maryam", "mozhdeh", "kianoosh"};
            names.WriteToConsole();
            int s = nums.MySum();

            names.MyForEach((n) => {
                Console.WriteLine($"name: {n}");
            });

            List<int> lnums = new List<int>();
            lnums.ForEach((n) => Console.WriteLine($"{n}"));

        }

        static void Main1(string[] args)
        {
            Dictionary<Student, double> grades = new Dictionary<Student, double>();
            var s1 = new Student("ali", 99521123);
            var s2 = new Student("maryam", 99521231);
            grades[s1] = 18.5;
            grades[s2] = 19;

            System.Console.WriteLine($"{s1.Name}: {grades[s1]}");
            System.Console.WriteLine($"{s2.Name}: {grades[s2]}");

            Stopwatch sw = Stopwatch.StartNew();
            for(int i=0; i<10_100; i++)
            {
                var ns = new Student((i/1000).ToString(), i);
                grades[ns] = i;
            }
            System.Console.WriteLine(sw.Elapsed.ToString());

            sw.Restart();
            Student snf = new Student("hossein", 999213412);
            for(int i=0; i<1000; i++)
                if (grades.ContainsKey(snf))
                    System.Console.WriteLine(snf);            
            System.Console.WriteLine(sw.Elapsed.ToString());
            while (true)
            {
                var s = Student.ReadFromConsole();
                if (grades.ContainsKey(s))
                    System.Console.WriteLine($"{s.Name}: {grades[s]}");
                else
                    System.Console.WriteLine("Not Found");
            }
        }
    }
}
