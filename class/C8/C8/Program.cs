using System;


namespace C8
{
    enum Color
    {
        Red,
        Green,
        Yellow,
    }

    enum StudentStatus: long
    {
        IsLocal=1,
        IsFemale=1 << 1,
        IsMarried=1 << 2,
        IsGraduateStudent=1 << 3,
        IsLeftHanded=1 << 4, // 1, 10000, 0x10, 
        IsSensitive = IsFemale | IsGraduateStudent
    }

    class Student
    {
        public string Name; // = default(string);
        public int Id ;
        public Color FavoriteColor;
        public StudentStatus Status;

        public bool IsLocal()
        {
            return (this.Status & StudentStatus.IsLocal) > 0;
        }

        public bool IsMarried()
        {
            return (this.Status & StudentStatus.IsMarried) >0;
        }

        public bool IsSenstive()
        {
            return (this.Status & StudentStatus.IsSensitive) == 
                    StudentStatus.IsSensitive;
        }
    }

    class Instructor
    {
        public string Name;
    }

    class Program
    {

        // static void PrintName(Student s)
        // {}

        // static void PrintName(Instructor i)
        // {}

        static void PrintId(int id){}

        static void Test()
        {
            double d = 5.0;

            if ((int)d == d)
            {
                // PrintId(d);
            }

        }

        static void PrintName(object[] objs)
        {
            foreach(object o in objs)
            {
                PrintName(o);
            }
            Color c = (Color) 5;
            char s;
        }


        static void PrintName(object o)
        {
            if (o is Student)
            {
                // Student s = (Student) o;
                Student s = o as Student;
                System.Console.WriteLine($"Student Name is {s.Name}");
            }
            else if (o is Instructor)
            {
                Instructor i = (Instructor)o;
                System.Console.WriteLine($"Instructor Name is {i.Name}");
            }
            else
            {
                System.Console.WriteLine($"Unknown Type: {o}");
            }
        }

        static void Main(string[] args)
        {
            Student s = new Student{Name = "Zohreh"};
            Instructor i = new Instructor{Name = "Jaleh"};

            object[] people = new object[6];
            people[0] = s;
            people[1] = i;
            people[2] = new Student{Name = "Ali"};
            people[3] = new Instructor{Name = "Ali Instructor"};
            people[4] = 5;
            people[5] = "Alexandra";

            object o = 5;
            o = 6;
            Student s1 = new Student(){Name = "Zahra"};
            s1 = new Student(){Name="Ali"};

            PrintName(people);
            // PrintName(s);
            // PrintName(i);              
            // Nullable<int>
            int w;
            int? x = null;
            int t = 0;
            bool is_t_Assigned = false;
            
            t = 5;
            is_t_Assigned = true;

            if (is_t_Assigned) // (t != 0)
                Console.WriteLine($"number of errors found and is {t}");
            else
                Console.WriteLine($"number of errors unknown");
            

            if (x.HasValue)
                System.Console.WriteLine(x.Value);

        }
        static void Main1(string[] args)
        {
            Student s = new Student{Name="Zohreh", Id=234, FavoriteColor=Color.Red};
            s.Status = StudentStatus.IsLocal | 
                        StudentStatus.IsSensitive | 
                        StudentStatus.IsMarried;
            
            int i = 1 | 4 | 8;

            Color c = (Color) 3;


            Console.WriteLine("Hello World!");
        }
    }
}

