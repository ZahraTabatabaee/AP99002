using System;
using System.IO;
using System.Linq;

namespace C23
{
    class Student
    {
        private int _id;
        public int Id
        {
            get{
                if (_id < 0)
                    throw new InvalidOperationException("Invalid State, Id is negative");
                return _id;
            }
            set{
                if (value < 0)
                    throw new InvalidDataException("id must be positive");
                _id = value;
            }
        }
        public Student(int id, string name)
        {
            if (id < 0)
                throw new InvalidDataException("id must be positive");
        }

    }

    class Program
    {

        public static void Main566(string[] args)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            Student s = new Student(id, name);
            dynamic Amoozesh = null;;
            if (s != null)
                Amoozesh.Register(s);
        }

        // static void test(out int n)
        // {
        //     if (5 + 4 / 2 > 12)
        //         n = 5;

        // }

        static bool GetIntFromConsole(out int n, int from, int to, out bool notInRange)
        {
            notInRange = false;
            if (! int.TryParse(Console.ReadLine(), out n))
                return false;

            if (n < from || n > to)
                notInRange = true;

            System.Console.WriteLine("Got integer from console");
            return true;
        }

        static bool GetIntListFromConsole(int count, out int[] nums, int from, int to, bool[] rangeError)
        {
            nums = new int[count];
            bool all_success = true;
            for(int i=0; i<count; i++)
            {
                bool success= GetIntFromConsole(out nums[i], from, to, out rangeError[i]);
                all_success = all_success && success;
            }

            return all_success;
        }


        static int[] GetIntListFromConsole_Clean_Concise(int count, int from, int to) =>
            Enumerable.Range(1, count).Select(n => GetIntFromConsole(from, to)).ToArray();

        static int[] GetIntListFromConsole_Clean(int count, int from, int to)
        {
            int[] nums = new int[count];
            for(int i=0; i<count; i++)
            {
                nums[i] = GetIntFromConsole();
            }
            return nums;
        }

        static int GetIntFromConsole(int from=-1, int to=1)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < from || n > to)
                throw new InvalidDataException($"int must be between {from} and {to}");

            System.Console.WriteLine("Got integer from console");
            return n;
        }

        static int Main55(string[] args)
        {
            try
            {
                int[] nums = GetIntListFromConsole_Clean_Concise(5, -100, 100);
                return 1;
                // Cleanup
            }
            catch(FormatException fe)
            {
                Console.WriteLine($"Don't use my program again! {fe.Message}");
                return 1;
                // Cleanup
            }
            catch(InvalidDataException ide)
            {
                Console.WriteLine($"Try Again! {ide.Message}");
                return 1;
                //Cleanup
            }
            finally
            {
                // Cleanup
                System.Console.WriteLine("in main");
            }   
            // System.Console.WriteLine("out of main");//age catch va try return dashte bashe va finally bashe nwmiad inja
        }
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    int n = GetIntFromConsole();
                    System.Console.WriteLine(n * n);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);                    
                }

            }
        }

        static int GetIntFromConsoleCorrectly()
        {
            int n=0;
            while(true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    continue;
                }                
            }
            return n;

        }

        static void Main3(string[] args)
        {
            while(true)
            {
                try
                {
                    string s = Console.ReadLine(); // 5.0, aldsf
                    int n = int.Parse(s);
                    System.Console.WriteLine(n * n);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);                    
                }

            }
        }
        static void Main2(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine(); // 5.0, aldsf
                int n;
                if (int.TryParse(s, out n))
                    Console.WriteLine(n * n);
                else 
                    Console.WriteLine("Try Again!");                
            }
        }
    }
}
